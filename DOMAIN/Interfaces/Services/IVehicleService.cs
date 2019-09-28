using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Services
{
    public interface IVehicleService : IServiceBase<Vehicle>
    {
        IQueryable<Vehicle> GetVehicleId(int modelId, int variantId); //nije iq

        IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId); //nije iq

        IList<String> GetBrandModelVariantByVehicleID(int vehicleId);

    }
}
