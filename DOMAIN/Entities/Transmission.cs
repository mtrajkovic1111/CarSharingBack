using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Transmission
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}
