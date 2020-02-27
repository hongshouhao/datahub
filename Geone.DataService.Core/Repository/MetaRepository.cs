using Geone.DataService.Core.Exceptions;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
                return db.Select<MetaEntity>(predicate);
            }
        }

        public MetaEntity Get(MetaType metaType, string name, bool throwIfNotFound = true)
        {
            using (var db = _dbFactory.Open())
            {
                return db.Single<MetaEntity>(x => x.Name == name && x.MetaType == metaType);
            }
        }

        public void Delete(MetaType metaType, string name)
        {
            using (var db = _dbFactory.Open())
            {
                db.Delete(new MetaEntity { MetaType = metaType, Name = name });
            }
        }

        public void Insert(MetaEntity metaEntity)
        {
            using (var db = _dbFactory.Open())
            {
                if (Get(metaEntity.MetaType, metaEntity.Name) != null)
                {
                    throw new MetaAlreadyexistException(metaEntity.MetaType, metaEntity.Name);
                }
                db.Insert(metaEntity);
            }
        }

        public void Update(MetaEntity entity)
        {
            using (var db = _dbFactory.Open())
            {
                db.Update(entity);
            }
        }
    }
}
