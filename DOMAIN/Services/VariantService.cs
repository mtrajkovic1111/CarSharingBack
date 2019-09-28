using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Services
{
    public class VariantService : ServiceBase<Variant>, IVariantService
    {
        private readonly IVariantRepository _variantRepository;
        public VariantService(IVariantRepository variantRepository) : base(variantRepository)
        {
            _variantRepository = variantRepository;
        }

        public IQueryable<Variant> GetModelVariants(int modelId)
        {
            return _variantRepository.GetModelVariants(modelId);
        }

        public IQueryable<Variant> GetVariantsOfModel(string model)
        {
            return _variantRepository.GetVariantsOfModel(model);
        }
    }
}
