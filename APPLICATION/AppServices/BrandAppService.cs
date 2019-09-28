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
    public class BrandAppService : AppServiceBase<Brand>, IBrandAppService
    {
        private readonly IBrandService _BrandService;
        public BrandAppService(IBrandService brandService) : base(brandService)
        {
            _BrandService = brandService;
        }
    }
}
