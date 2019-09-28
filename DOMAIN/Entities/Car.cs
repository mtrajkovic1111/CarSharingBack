using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string LicencePlate { get; set; }
        public int EngineSize { get; set; }
        public byte Doors { get; set; }
        public int Year { get; set; }
        public byte PricePerDay { get; set; }
        public bool IsAvailable { get; set; }
        public bool HasNavigation { get; set; }
        public byte? NavigationPrice { get; set; }
        public bool HasEnsurance { get; set; }
        public byte? EnsurancePrice { get; set; }
        public bool HasAirCondition { get; set; }

        public byte[] CarPicture { get; set; }
        public ICollection<FuelType> FuelTypes { get; set; }

        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle{ get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<CarRental> CarRentals { get; set; }



    }
}
