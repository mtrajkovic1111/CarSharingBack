using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class VariantAppService : AppServiceBase<Variant>, IVariantAppService
    {
        private readonly IVariantService _VariantService;
        public VariantAppService(IVariantService variantService) : base(variantService)
        {
            _VariantService = variantService;
        }

        public IQueryable<Variant> GetModelVariants(int modelId)
        {
            return _VariantService.GetModelVariants(modelId);
        }

        public IQueryable<Variant> GetVariantsOfModel(string model)
        {
            return _VariantService.GetVariantsOfModel(model);
        }
    }
}
