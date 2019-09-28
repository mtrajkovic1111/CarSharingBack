using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        public string BodyType { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
