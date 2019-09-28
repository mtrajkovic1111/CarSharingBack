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
    public class ModelAppService : AppServiceBase<Model>, IModelAppService
    {
        private readonly IModelService _ModelService;
        public ModelAppService(IModelService modelService) : base(modelService)
        {
            _ModelService = modelService;
        }

        public IQueryable<Model> GetAllModelsForBrand(string brand)
        {
            return _ModelService.GetAllModelsForBrand(brand);
        }

        public IQueryable<Model> GetModelsForBrand(int brandId)
        {
            return _ModelService.GetModelsForBrand(brandId);
        }
    }
}
