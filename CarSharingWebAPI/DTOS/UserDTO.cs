using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Rate { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string ContactPhone { get; set; }
        public ICollection<CarDTO> CarsDTO { get; set; }

        public ICollection<CarRentalDTO> CarRentalsDTO { get; set; }
    }
}