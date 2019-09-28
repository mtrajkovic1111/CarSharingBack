using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using DOMAIN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class VehicleAppService : AppServiceBase<Vehicle>, IVehicleAppService
    {
        private readonly IVehicleService _vehicleService;

        public VehicleAppService(IVehicleService vehicleService) : base(vehicleService)
        {
            _vehicleService = vehicleService;
        }
        public IQueryable<Vehicle> GetVehicleId(int modelId, int variantId)
        {
            return _vehicleService.GetVehicleId(modelId, variantId);
        }

        public IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId)
        {
            return _vehicleService.GetModelVariantByVehicleId(vehicleId);
          
        }

        public IList<String> GetBrandModelVariantByVehicleID(int vehicleId)
        {
            return _vehicleService.GetBrandModelVariantByVehicleID(vehicleId);
        }
    }
}
