using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Services
{
    public class ModelService : ServiceBase<Model>, IModelService
    {
        private readonly IModelRepository _modelRepository;
        public ModelService(IModelRepository modelRepository) : base(modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public IQueryable<Model> GetAllModelsForBrand(string brand)
        {
            return _modelRepository.GetAllModelsForBrand(brand);
        }

        public IQueryable<Model> GetModelsForBrand(int brandId)
        {
            return _modelRepository.GetModelsForBrand(brandId);
        }
    }
}
