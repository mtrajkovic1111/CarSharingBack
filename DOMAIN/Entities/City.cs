using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
