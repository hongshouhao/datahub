using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service.DBaaS;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;

namespace Geone.DataService.Core
{
    public class DsSetup
    {
        readonly IDbConnectionFactory _dbFactory;
        public DsSetup(IDbConnectionFactory dbFactory)
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
