using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class VariantDTO
    {
        public int Id { get; set; }
        public string BodyType { get; set; }

        public ICollection<VehicleDTO> VehiclesDTO { get; set; }

    }
}