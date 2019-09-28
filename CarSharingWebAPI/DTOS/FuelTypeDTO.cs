using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class FuelTypeDTO
    {
        public int Id { get; set; }
        public string Fuel { get; set; }

        public ICollection<CarDTO> CarsDTO { get; set; }
    }
}