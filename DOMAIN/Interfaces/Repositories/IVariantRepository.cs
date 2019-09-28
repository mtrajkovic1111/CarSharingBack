using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Repositories
{
    public interface IVariantRepository : IRepositoryBase<Variant>
    {
        IQueryable<Variant> GetVariantsOfModel(string model);
        IQueryable<Variant> GetModelVariants(int modelId);
    }
}
