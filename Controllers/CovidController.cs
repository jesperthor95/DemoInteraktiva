using DemoInteraktiva.Models;
using DemoInteraktiva.Models.ViewModels;
using DemoInteraktiva.Repositiories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Controllers
{
    public class CovidController : Controller
    {
        private readonly IRepository repository;

        public CovidController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var countries = await repository.GetCountriesAsync();
            var model = new CovidViewModel(countries);
            return View(model);
        }
         
        [HttpGet]
        
        public async Task<IActionResult> Serach(string selectedCountry)
        {
            var countries = await repository.GetCountriesAsync();
            var data = await repository.GetCountryTotal(selectedCountry);
            if (data.Count() == 0)
            {
                ModelState.AddModelError("NoContent", "Det finns ingen statistik för det landet"); // information om själva modellen
            }
            var model = new CovidViewModel(countries);
            return View("index", model);
        }



    }
}
