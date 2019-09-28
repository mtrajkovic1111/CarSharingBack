using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Model { get; set; }
    }
}
