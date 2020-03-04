using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Repository;
using System;
using System.Data.Common;
using System.Text;

namespace Geone.DataService.Core.Service.DBaaS
{
    public class DbCommandExcutor
    {
        readonly MetaRepository _repository;
        public DbCommandExcutor(MetaRepository repository)
        {
            _repository = repository;
        }

        public string Excute(DbCommandMeta dbCommand)
        {
            MetaEntity entity = _repository.Get(MetaType.Db, dbCommand.Database);
            DbMeta dbMeta = entity.GetMetadata() as DbMeta;

            DbProviderFactory provider = DbFactories.Get(dbMeta.Type);
            using (DbConnection connection = provider.CreateConnection())
            {
                connection.ConnectionString = dbMeta.ConnectionString;
                connection.Open();
                using (DbTransaction trans = connection.BeginTransaction())
                {
                    DbCommand command = provider.CreateCommand();
                    command.CommandText = dbCommand.CommandText;
                    command.Connection = connection;
                    command.Transaction = trans;

                    foreach (var pitem in dbCommand.Parameters)
                    {
                        DbParameter parameter = command.CreateParameter();
                        parameter.ParameterName = pitem.Key;
                        parameter.Value = pitem.Value;

                        command.Parameters.Add(parameter);
                    }

                    if (dbCommand.CommandTimeout > 0)
                    {
                        command.CommandTimeout = dbCommand.CommandTimeout;
                    }

                    string json;
                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        json = ToJson(dataReader);
                    }

                    trans.Commit();

                    return json;
                }
            }
        }

        public static string ToJson(DbDataReader dataReader)
        {
            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("[");
            while (dataReader.Read())
            {
                jsonString.Append("{");
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Type type = dataReader.GetFieldType(i);
                    jsonString.AppendFormat("\"{0}\":", dataReader.GetName(i));
                    string strValue = StringFormat(dataReader[i].ToString(), type);

                    if (i < dataReader.FieldCount - 1)
                    {
                        jsonString.AppendFormat("{0},", strValue);
                    }
                    else
                    {
                        jsonString.Append(strValue);
                    }
                }
                jsonString.Append("},");
            }
            jsonString.Remove(jsonString.Length - 1, 1);
            jsonString.Append("]");
            return jsonString.ToString();
        }

        private static string StringFormat(string str, Type type)
        {
            if (type == stringType)
            {
                return $"\"{String2Json(str)}\"";
            }
            else if (type == datetimeType)
            {
                return $"\"{str}\"";
            }
            else if (type == boolType)
            {
                return str.ToLower();
            }
            else
            {
                return $"\"{str}\"";
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
    }
}
