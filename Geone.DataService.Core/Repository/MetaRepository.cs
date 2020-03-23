using Geone.DataService.Core.Exceptions;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Geone.DataService.Core.Metadata;
using System.Data;

namespace Geone.DataService.Core.Repository
{
    public class MetaRepository
    {
        private readonly IDbConnectionFactory _dbFactory;
        public MetaRepository(IDbConnectionFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<MetaEntity> Query(Expression<Func<MetaEntity, bool>> predicate)
        {
            using (var db = _dbFactory.Open())
            {
                return db.Select(predicate);
            }
        }

        public MetaEntity Get(MetaType metaType, string name, bool throwIfNotFound = true)
        {
            using (var db = _dbFactory.Open())
            {
                MetaEntity entity = db.Single<MetaEntity>(x => x.Name == name && x.MetaType == metaType);
                if (entity == null && throwIfNotFound)
                {
                    throw new DataServiceException($"找不到\"{metaType.GetDescription()}({name})\"元数据", 404);
                }

                return entity;
            }
        }

        public void Delete(MetaType metaType, string name)
        {
            using (var db = _dbFactory.Open())
            {
                using (var trans = db.OpenTransaction())
                {
                    db.Delete<MetaEntity>(x => x.MetaType == metaType && x.Name == name);
                    if (metaType == MetaType.Service)
                    {
                        var todelete = db.Select((Expression<Func<MetaEntity, bool>>)(x => x.MetaType == MetaType.ServiceTest))
                              .Where(x => (x.GetMetadata() as ServiceTestMeta).ServiceName.ToLower() == name.ToLower())
                              .ToArray();

                        db.DeleteAll(todelete);
                    }

                    trans.Commit();
                }
            }
        }

        public void Insert(MetaEntity metaEntity)
        {
            if (Get(metaEntity.MetaType, metaEntity.Name, false) != null)
            {
                throw new DataServiceException($"已存在\"{metaEntity.MetaType.GetDescription()}({metaEntity.Name})\"元数据", 409);
            }

            using (var db = _dbFactory.Open())
            {
                CheckServiceExistForTest(metaEntity, db);
                db.Insert(metaEntity);
            }
        }

        public void Update(MetaEntity metaEntity)
        {
            using (var db = _dbFactory.Open())
            {
                CheckServiceExistForTest(metaEntity, db);
                db.Update(metaEntity);
            }
        }

        private static void CheckServiceExistForTest(MetaEntity metaEntity, IDbConnection db)
        {
            if (metaEntity.MetaType == MetaType.ServiceTest)
            {
                ServiceTestMeta serviceTestMeta = metaEntity.GetMetadata() as ServiceTestMeta;
                MetaEntity serviceEntity = db.Single<MetaEntity>(x =>
                    x.Name == serviceTestMeta.ServiceName && x.MetaType == MetaType.Service);

                if (serviceEntity == null)
                {
                    throw new DataServiceException($"\"服务测试({metaEntity.Name})\"元数据存在错误: 找不到\"服务测试({serviceTestMeta.ServiceName})\"元数据", 404);
                }
            }
        }
    }
}
