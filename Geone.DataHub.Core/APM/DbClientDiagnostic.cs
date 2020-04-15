using Geone.DataHub.Core.Metadata;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace Geone.DataHub.Core.APM
{
    public static class DbClientDiagnostic
    {
        public class DbEventArgs
        {
            public Guid Id { get; internal set; }
        }

        public class BeforeConnecttingEventArgs : DbEventArgs
        {
            public DbTypes DbType { get; internal set; }
            public string DataSource { get; internal set; }
            public string Address { get; internal set; }
            public int? Port { get; internal set; }
        }

        public class BeforeExecutingEventArgs : BeforeConnecttingEventArgs
        {
            public string Database { get; internal set; }
            public string CommandText { get; internal set; }
            public Dictionary<string, object> Parameters { get; internal set; } = new Dictionary<string, object>();
        }

        public class ErrorEventArgs : DbEventArgs
        {
            public Exception Exception { get; internal set; }
        }

        public class AfterReadingResultEventArgs : DbEventArgs
        {
            public int RowsCount { get; internal set; }
            public string Result { get; internal set; }
        }

        public const string DB_DIAGNOSTIC_LISTENER = "MyDbCommandDiagnosticListener";
        public const string PREFIX = "My.";

        public const string BEFORE_CONNECTING = PREFIX + nameof(BeforeOpenConnection);
        public const string AFTER_CONNECTING = PREFIX + nameof(AfterConnecting);

        public const string BEFORE_COMMAND_EXECUTE = PREFIX + nameof(BeforeExecutingCommand);
        public const string AFTER_COMMAND_EXECUTE = PREFIX + nameof(AfterExecutingCommand);
        public const string ERROR_COMMAND_EXECUTE = PREFIX + nameof(ErrorExecutingCommand);

        public const string BEFORE_READ_JSON = PREFIX + nameof(BeforeReadingResult);
        public const string AFTER_READ_JSON = PREFIX + nameof(AfterReadingResult);

        private static readonly DiagnosticListener _diagnosticListener = new DiagnosticListener(DB_DIAGNOSTIC_LISTENER);

        public static Guid BeforeOpenConnection(DbTypes dbType, string connectionString)
        {
            if (!_diagnosticListener.IsEnabled(BEFORE_CONNECTING)) return Guid.Empty;

            var id = Guid.NewGuid();
            var conn = Get(dbType, connectionString);
            _diagnosticListener.Write(BEFORE_CONNECTING, new BeforeConnecttingEventArgs()
            {
                Id = id,
                DbType = dbType,
                Address = conn.Item1,
                Port = conn.Item2
            });
            return id;
        }

        public static void AfterConnecting(Guid id)
        {
            if (_diagnosticListener.IsEnabled(AFTER_CONNECTING))
            {
                _diagnosticListener.Write(AFTER_CONNECTING, new DbEventArgs
                {
                    Id = id
                });
            }
        }

        public static Guid BeforeExecutingCommand(DbTypes dbType, DbCommand command, Dictionary<string, object> parameters)
        {
            if (!_diagnosticListener.IsEnabled(BEFORE_COMMAND_EXECUTE)) return Guid.Empty;

            var id = Guid.NewGuid();
            var conn = Get(dbType, command.Connection.ConnectionString);
            _diagnosticListener.Write(BEFORE_COMMAND_EXECUTE, new BeforeExecutingEventArgs()
            {
                Id = id,
                DbType = dbType,
                Address = conn.Item1,
                Port = conn.Item2,
                CommandText = command.CommandText,
                Database = command.Connection.Database,
                Parameters = parameters
            });

            return id;
        }

        private const int MaxCacheSize = 100;
        private static int _cacheCount;
        private static readonly ConcurrentDictionary<string, Tuple<string, int?>> _cache = new ConcurrentDictionary<string, Tuple<string, int?>>();
        private static Tuple<string, int?> Get(DbTypes dbType, string connectionString)
        {
            if (_cache.TryGetValue(connectionString, out Tuple<string, int?> builder))
            {
                return builder;
            }

            switch (dbType)
            {
                case DbTypes.MsSql:
                    SqlConnectionStringBuilder mssql = new SqlConnectionStringBuilder(connectionString);
                    builder = new Tuple<string, int?>(mssql.DataSource, null);
                    break;
                case DbTypes.PostgreSql:
                    NpgsqlConnectionStringBuilder npgsql = new NpgsqlConnectionStringBuilder(connectionString);
                    builder = new Tuple<string, int?>(npgsql.Host, npgsql.Port);
                    break;
                case DbTypes.MySql:
                    MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder(connectionString);
                    builder = new Tuple<string, int?>(mysql.Server, (int)mysql.Port);
                    break;
                case DbTypes.Oracle:
                    OracleConnectionStringBuilder ora = new OracleConnectionStringBuilder(connectionString);
                    builder = new Tuple<string, int?>(ora.DataSource, null);
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (_cacheCount < MaxCacheSize && _cache.TryAdd(connectionString, builder))
                Interlocked.Increment(ref _cacheCount);
            return builder;
        }

        public static void AfterExecutingCommand(Guid id)
        {
            if (_diagnosticListener.IsEnabled(AFTER_COMMAND_EXECUTE))
            {
                _diagnosticListener.Write(AFTER_COMMAND_EXECUTE, new DbEventArgs()
                {
                    Id = id,
                });
            }
        }

        public static void ErrorExecutingCommand(Guid id, Exception ex)
        {
            if (_diagnosticListener.IsEnabled(ERROR_COMMAND_EXECUTE))
            {
                _diagnosticListener.Write(ERROR_COMMAND_EXECUTE, new ErrorEventArgs()
                {
                    Id = id,
                    Exception = ex
                });
            }
        }

        public static Guid BeforeReadingResult()
        {
            if (!_diagnosticListener.IsEnabled(BEFORE_READ_JSON)) return Guid.Empty;

            var id = Guid.NewGuid();
            _diagnosticListener.Write(BEFORE_READ_JSON, new DbEventArgs()
            {
                Id = id,
            });

            return id;
        }

        public static void AfterReadingResult(Guid id, int count, string json)
        {
            if (_diagnosticListener.IsEnabled(AFTER_READ_JSON))
            {
                _diagnosticListener.Write(AFTER_READ_JSON, new AfterReadingResultEventArgs()
                {
                    Id = id,
                    Result = json,
                    RowsCount = count,
                });
            }
        }
    }
}
