using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Fuel { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
