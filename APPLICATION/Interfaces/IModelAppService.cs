using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
   public interface IModelAppService : IAppServiceBase<Model>
    {
        IQueryable<Model> GetAllModelsForBrand(string brand);
        IQueryable<Model> GetModelsForBrand(int brandId);
    }
}
