using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public int ModelId { get; set; }
        public int VariantId { get; set; }

        public Model Model { get; set; }
        public Variant Variant { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
