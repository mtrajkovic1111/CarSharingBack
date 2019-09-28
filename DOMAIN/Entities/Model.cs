using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string ModelType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
