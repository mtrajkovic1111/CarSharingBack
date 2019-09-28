using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class CarRentalDTO
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime TillDate { get; set; }
        public byte TotalPricePerDay { get; set; }
        public bool RentedWithNavigation { get; set; }
        public bool RentedWithEnsurance { get; set; }
        public int CarId { get; set; }
        public CarDTO CarDTO { get; set; }

        public int UserId { get; set; }
        public UserDTO UserDTO { get; set; }
    }
}