using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Models;

namespace CityInfo.Controllers
{
    public class CitiesController: Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCiTies()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("api/cities/{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
