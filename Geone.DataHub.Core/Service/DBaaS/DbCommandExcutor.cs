using Geone.DataHub.Core.APM;
using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Org.BouncyCastle.Crypto.Engines;
using ServiceStack;
using System;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;

namespace Geone.DataHub.Core.Service.DBaaS
{
    public class DbCommandExcutor
    {
        readonly MetaRepository _repository;
        public DbCommandExcutor(MetaRepository repository)
        {
            _repository = repository;
        }

        public object Excute(DbCommandMeta cmdMeta)
        {
            MetaEntity entity = _repository.Get(MetaType.Db, cmdMeta.Database);
            DbMeta dbMeta = entity.GetMetadata() as DbMeta;

            DbProviderFactory provider = DbFactories.Get(dbMeta.Type);
            using (DbConnection connection = provider.CreateConnection())
            {
                Guid connId = DbClientDiagnostic.BeforeOpenConnection(dbMeta.Type, dbMeta.ConnectionString);
                connection.ConnectionString = dbMeta.ConnectionString;
                connection.Open();
                DbClientDiagnostic.AfterConnecting(connId);

                using (DbTransaction trans = connection.BeginTransaction())
                {
                    using (DbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = cmdMeta.CommandText;
                        command.Connection = connection;
                        command.Transaction = trans;

                        foreach (var pitem in cmdMeta.Parameters)
                        {
                            DbParameter parameter = command.CreateParameter();
                            parameter.ParameterName = pitem.Key;

                            if (pitem.Value != null)
                            {
                                string valString = pitem.Value.ToString();
                                if (valString.StartsWith("base64:"))
                                {
                                    string base64 = valString.Substring(7);
                                    parameter.Value = Encoding.UTF8.GetBytes(base64);
                                }
                                else
                                {
                                    parameter.Value = pitem.Value;
                                }
                            }
                            else
                            {
                                parameter.Value = pitem.Value;
                            }

                            command.Parameters.Add(parameter);
                        }

                        if (cmdMeta.CommandTimeout > 0)
                        {
                            command.CommandTimeout = cmdMeta.CommandTimeout;
                        }

                        object result;

                        Guid excId = DbClientDiagnostic.BeforeExecutingCommand(dbMeta.Type, command, cmdMeta.Parameters);
                        DbDataReader dataReader = command.ExecuteReader();
                        DbClientDiagnostic.AfterExecutingCommand(excId);

                        using (dataReader)
                        {
                            if (dataReader.RecordsAffected > -1)
                            {
                                result = dataReader.RecordsAffected;
                            }
                            else
                            {
                                Guid readId = DbClientDiagnostic.BeforeReadingResult();
                                var json = ReadJson(dataReader);
                                DbClientDiagnostic.AfterReadingResult(readId, json.Item2, json.Item1);
                                result = json.Item1;
                            }
                        }

                        trans.Commit();
                        return result;
                    }
                }
            }
        }

        bool IsBase64(string stringValue)
        {
            return Regex.IsMatch("", "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)?$");
        }

        public static Tuple<string, int> ReadJson(DbDataReader dataReader)
        {
            StringBuilder json = new StringBuilder();

            json.Append("[");
            int count = 0;
            while (dataReader.Read())
            {
                count++;

                json.Append("{");
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    json.AppendFormat("\"{0}\":", dataReader.GetName(i));

                    string strValue = StringFormat(dataReader[i], dataReader.GetFieldType(i));

                    if (i < dataReader.FieldCount - 1)
                    {
                        json.AppendFormat("{0},", strValue);
                    }
                    else
                    {
                        json.Append(strValue);
                    }
                }
                json.Append("},");
            }

            if (json.Length > 1)
            {
                json.Remove(json.Length - 1, 1);
            }

            json.Append("]");

            return new Tuple<string, int>(json.ToString(), count);
        }

        private static string StringFormat(object value, Type type)
        {
            if (value == null)
            {
                return "null";
            }

            if (type == stringType || type == charType)
            {
                string str = value.ToString();
                if (str.Length == 0)
                {
                    return "\"\"";
                }
                else
                {
                    return $"\"{String2Json(str)}\"";
                }
            }
            else if (type == datetimeType)
            {
                return $"\"{value}\"";
            }
            else if (type == boolType)
            {
                return value.ToString().ToLower();
            }
            else if (type.IsNumericType() || type == byteType)
            {
                return $"{value}";
            }
            else if (type == byteArrayType)
            {
                byte[] bytes = value as byte[];
                string base64 = Convert.ToBase64String(bytes);
                return $"\"base64:{base64}\"";
            }
            else
            {
                return $"\"{value}\"";
            }
        }

        private static string String2Json(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                switch (c)
                {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        static Type stringType = typeof(string);
        static Type datetimeType = typeof(DateTime);
        static Type boolType = typeof(bool);
        static Type charType = typeof(char);
        static Type byteType = typeof(byte);
        static Type byteArrayType = typeof(byte[]);
    }
}
