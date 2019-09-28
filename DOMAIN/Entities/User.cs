using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        // public String Password { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int? Rate { get; set; }
        public string ContactPhone { get; set; }
        public ICollection<Car> Cars { get; set; }
        public ICollection<CarRental> CarRentals { get; set; }
    }
}
