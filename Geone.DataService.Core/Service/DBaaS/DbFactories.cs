using Geone.DataService.Core.Metadata;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data.Common;
using System.Data.SqlClient;

namespace Geone.DataService.Core.Service.DBaaS
{
    public class DbFactories
    {
        public static void Register()
        {
            DbProviderFactories.RegisterFactory(DbTypes.MsSql.ToString(), SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory(DbTypes.MySql.ToString(), MySqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory(DbTypes.PostgreSql.ToString(), NpgsqlFactory.Instance);
        }

        public static DbProviderFactory Get(DbTypes dbType)
        {
            return DbProviderFactories.GetFactory(dbType.ToString());
        }
    }
}
