using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class VehicleDTO
    {
        public int Id { get; set; }

        public int ModelId { get; set; }
        public int VariantId { get; set; }

        public ModelDTO ModelDTO { get; set; }
        public VariantDTO VariantDTO { get; set; }

        public ICollection<CarDTO> CarsDTO { get; set; }
    }
}