﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class CityDto
    {
        public int Id { get; set;}
        public string name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointOfInterest { get; set; }

    }
}
