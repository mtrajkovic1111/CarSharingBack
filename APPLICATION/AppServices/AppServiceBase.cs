using APPLICATION.Interfaces;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _ServiceBase;
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _ServiceBase = serviceBase;

        }
        public void Add(TEntity obj)
        {
            _ServiceBase.Add(obj);
        }

        //public void Dispose()
        //{
        //    _serviceBase.dis
        //}

        public IQueryable<TEntity> GetAll()
        {
            return _ServiceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _ServiceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _ServiceBase.Remove(obj);
        }

        //public void Save()
        //{
        //    _serviceBase.s
        //}

        public void Update(TEntity obj)
        {
            _ServiceBase.Update(obj);
        }
    }
}
