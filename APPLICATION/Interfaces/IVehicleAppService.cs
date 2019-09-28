using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
    public interface IVehicleAppService : IAppServiceBase<Vehicle>
    {
        IQueryable<Vehicle> GetVehicleId(int modelId, int variantId);
        IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId);

        IList<String> GetBrandModelVariantByVehicleID(int vehicleId);

    }
}
