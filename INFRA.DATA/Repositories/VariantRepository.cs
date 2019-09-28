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
    public class VariantRepository : RepositoryBase<Variant>, IVariantRepository
    {
        public VariantRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Variant> GetModelVariants(int modelId)
        {
            var variantOfModel = context.Variants.Where(v => v.Vehicles.Any(m => m.ModelId == modelId));
            return (variantOfModel);
        }

        public IQueryable<Variant> GetVariantsOfModel(string model)
        {
            //var modelVariants = context.Variants.Where(v => v.Models.Any(m => m.ModelType == model));
            //return modelVariants;
            //var variant = context.Variants.Where(v => v.Vehicles)
            return null;
        }
    }
}
