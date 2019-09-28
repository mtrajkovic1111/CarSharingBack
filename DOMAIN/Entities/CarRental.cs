using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class CarRental
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime TillDate { get; set; }
        public byte TotalPricePerDay { get; set; }
        public bool RentedWithNavigation { get; set; }
        public bool RentedWithEnsurance { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
