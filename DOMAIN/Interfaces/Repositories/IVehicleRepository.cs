using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Repositories
{
    public interface IVehicleRepository: IRepositoryBase<Vehicle>
    {
        IQueryable<Vehicle> GetVehicleId(int modelId, int variantId);
        IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId);
        IList<String> GetBrandModelVariantByVehicleID(int vehicleId);


    }
}
