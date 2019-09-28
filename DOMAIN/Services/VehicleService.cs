using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Services
{
    public class VehicleService : ServiceBase<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository) : base(vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public IQueryable<Vehicle> GetVehicleId(int modelId, int variantId)
        {
            return _vehicleRepository.GetVehicleId(modelId, variantId);
        }

        public IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId)
        {
            return _vehicleRepository.GetModelVariantByVehicleId(vehicleId);
        }

        public IList<String> GetBrandModelVariantByVehicleID(int vehicleId)
        {
            return _vehicleRepository.GetBrandModelVariantByVehicleID(vehicleId);
        }

    }
}
