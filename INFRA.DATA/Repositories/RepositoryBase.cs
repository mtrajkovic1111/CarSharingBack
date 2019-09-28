using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context context;

        public RepositoryBase(IUnitOfWork<Context> unitOfWork)
        {
            context = unitOfWork.Context;
        }

        public void Add(TEntity obj)
        {
            context.Set<TEntity>().AddOrUpdate(obj);
        }


        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
        }

        public void Update(TEntity obj)
        {
            context.Set<TEntity>().AddOrUpdate(obj);
        }
    }
}
