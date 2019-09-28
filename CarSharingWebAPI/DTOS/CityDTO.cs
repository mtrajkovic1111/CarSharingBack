using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AddressDTO> AddressesDTO { get; set; }
    }
}