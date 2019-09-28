using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public ICollection<Car> Cars{ get; set; }
        public int CityId { get; set; }
        public City City { get; set; }


    }
}
