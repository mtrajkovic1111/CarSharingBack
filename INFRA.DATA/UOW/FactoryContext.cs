using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.UOW
{
    public class FactoryContext<T> : IDbContextFactory<T> where T : DbContext
    {
        public T Create()
        {
            return new Context() as T;
        }
    }
}
