using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.UOW
{
    public class UnitOfWork<T> : IDisposable, IUnitOfWork<T> where T : DbContext
    {
        public T Context { get; }
        public UnitOfWork()
        {
            Context = new FactoryContext<T>().Create();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
