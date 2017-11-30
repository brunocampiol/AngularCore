using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularCore.Controllers
{
    public class SampleController : Controller
    {
        private class Weather
        {
            public string City;
            public float Temp;
            public string Summary;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetSampleWeather()
        {
            Weather w = new Weather();

            w.City = "Dubai";
            w.Temp = 21.5f;
            w.Summary = "Very good eather, m8";


            return new JsonResult(w);
        }

        public IActionResult GetWeather(string chosenCity)
        {
            Weather w = new Weather();

            w.City = "Dubai";
            w.Temp = 21.5f;
            w.Summary = "Very good eather, m8";


            return new JsonResult(w);
        }
    }
}