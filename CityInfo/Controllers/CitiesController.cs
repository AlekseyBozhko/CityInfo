using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Controllers
{
    public class CitiesController: Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCiTies()
        {
            return new JsonResult(new List<object>()
            {
                new { id = 1, Name = "NY" },
                new { id = 2, Name = "London" },
            });
        }
    }
}
