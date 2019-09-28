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
    public class CityAppService : AppServiceBase<City>, ICityAppService
    {
        private readonly ICityService _CityService;
        public CityAppService(ICityService cityService) : base(cityService)
        {
            _CityService = cityService;
        }
    }
}
