using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class BrandDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelDTO> ModelDTO { get; set; }
    }
}