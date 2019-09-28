using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class CarDTO
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
        public ICollection<FuelTypeDTO> FuelTypesDTO { get; set; }

        public int TransmissionId { get; set; }
        public TransmissionDTO TransmissionDTO { get; set; }

        public int AddressId { get; set; }
        public AddressDTO AddressDTO { get; set; }

        public int VehicleId { get; set; }
        public  VehicleDTO VehicleDTO { get; set; }

        public int UserId { get; set; }
        public UserDTO UserDTO { get; set; }

        public ICollection<CarRentalDTO> CarRentalDTO { get; set; }
    }
}