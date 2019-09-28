using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class ModelDTO
    {
        public int Id { get; set; }
        public string ModelType { get; set; }
        public int BrandId { get; set; }
        public BrandDTO BrandDTO { get; set; }
        public ICollection<VehicleDTO> VehiclesDTO { get; set; }
    }
}