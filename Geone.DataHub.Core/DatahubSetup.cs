using Geone.DataHub.Core.Repository;
using Geone.DataHub.Core.Service.DBaaS;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;

namespace Geone.DataHub.Core
{
    public class DatahubSetup
    {
        readonly IDbConnectionFactory _dbFactory;
        public DatahubSetup(IDbConnectionFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Initialize()
        {
            DbFactories.Register();
            using (var db = _dbFactory.Open())
            {
                db.CreateTableIfNotExists<MetaEntity>();
            }

            OrmLiteConfig.InsertFilter = (dbCmd, row) =>
            {
                if (row is IAudit auditRow)
                    auditRow.CreatedDate = auditRow.ModifiedDate = DateTime.UtcNow;
            };

            OrmLiteConfig.UpdateFilter = (dbCmd, row) =>
            {
                if (row is IAudit auditRow)
                    auditRow.ModifiedDate = DateTime.UtcNow;
            };
        }
    }
}
