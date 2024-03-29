﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    name = "NY",
                    Description = "towers"
                },

                new CityDto()
                {
                    Id = 2,
                    name = "London",
                    Description = "towers dependens"
                }
            };
        }
    }
}
