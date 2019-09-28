using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Services
{
    public class CityService : ServiceBase<City>, ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository) : base(cityRepository)
        {
            _cityRepository = cityRepository;
        }
    }
}
