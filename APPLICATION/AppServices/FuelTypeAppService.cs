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
    public class FuelTypeAppService : AppServiceBase<FuelType>, IFuelTypeAppService
    {
        private readonly IFuelTypeService _FuelTypeService;
        public FuelTypeAppService(IFuelTypeService fuelTypeService) : base(fuelTypeService)
        {
            _FuelTypeService = fuelTypeService;
        }
    }
}
