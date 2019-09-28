using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class ModelRepository : RepositoryBase<Model>, IModelRepository
    {
        public ModelRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Model> GetAllModelsForBrand(string brand)
        {
            var models = context.Models.Where(m => m.Brand.Name == brand);
            return models;
        }

        public IQueryable<Model> GetModelsForBrand(int brandId)
        {
            var models = context.Models.Where(m => m.Brand.Id == brandId);
            return models;
        }
    }
}
