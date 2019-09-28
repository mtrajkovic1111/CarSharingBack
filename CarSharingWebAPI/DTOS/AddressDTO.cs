using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public ICollection<CarDTO> CarsDTO { get; set; }
        public int CityId { get; set; }
        public CityDTO CityDTO { get; set; }
    }
}