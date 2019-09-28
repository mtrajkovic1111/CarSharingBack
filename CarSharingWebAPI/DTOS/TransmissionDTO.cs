﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.DTOS
{
    public class TransmissionDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<CarDTO> CarsDTO { get; set; }
    }
}