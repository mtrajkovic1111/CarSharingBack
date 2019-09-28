using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Services
{
    public interface IModelService : IServiceBase<Model>
    {
        IQueryable<Model> GetAllModelsForBrand(string brand);
        IQueryable<Model> GetModelsForBrand(int brandId);

    }
}
