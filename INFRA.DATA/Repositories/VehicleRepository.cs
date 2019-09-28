using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Vehicle> GetVehicleId(int modelId, int variantId)
        {
            var vehicleId = context.Vehicles.Where(v => v.ModelId == modelId && v.VariantId == variantId);
            return vehicleId;
        }

        public IQueryable<Vehicle> GetModelVariantByVehicleId(int vehicleId)
        {
            var vehicle = context.Vehicles.Where(v => v.Id == vehicleId);
            return vehicle;
        }

        public IList<String> GetBrandModelVariantByVehicleID(int vehicleId)
        {
            var str = context.Vehicles.Include("Model.Brand").Include("Variant").Where(v => v.Id == vehicleId).SingleOrDefault();
            var list = new List<string>();
            list.Add( str.Model.Brand.Name);
            list.Add(str.Model.ModelType);
            list.Add(str.Variant.BodyType);
            return list;


        }
        
    }
}
