using Geone.DataHub.Core.Metadata;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace Geone.DataHub.Core.Service.DBaaS
{
    public class DbFactories
    {
        public static void Register()
        {
            DbProviderFactories.RegisterFactory(DbTypes.MsSql.ToString(), SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory(DbTypes.MySql.ToString(), MySqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory(DbTypes.PostgreSql.ToString(), NpgsqlFactory.Instance);
            DbProviderFactories.RegisterFactory(DbTypes.Oracle.ToString(), OracleClientFactory.Instance);
        }

        public static DbProviderFactory Get(DbTypes dbType)
        {
            return DbProviderFactories.GetFactory(dbType.ToString());
        }
    }
}
