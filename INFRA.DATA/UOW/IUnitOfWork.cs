using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.UOW
{
    public interface IUnitOfWork<T> where T : DbContext
    { 
        T Context{  get; }
        void Save();
        void Dispose();
    }
}
