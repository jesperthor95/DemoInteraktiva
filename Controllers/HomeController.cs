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
    public class HomeController : Controller
    {
        private IRepository repository;

        //Dependecy injection
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        //Dependency inversion
        public async Task <IActionResult> Index()
        {
            // hämta från api
            // hantera resultatet du hämtar
            var tasks = new List<Task>();
            var CountryTotals = new List<List<TotalDto>>();
            var countries = await repository.GetCountriesAsync(); //Hämtar en lista av länder från API
           

            //try
            //{
            //    foreach (var country in countries)
            //    {
            //        tasks.Add(
            //            Task.Run(
            //                    async () =>
            //                    {
            //                        var result = await repository.GetCountryTotal(country.Slug);
            //                        CountryTotals.Add(result.ToList());
            //                    }
            //                )
            //            );
            //    }
            //    await Task.WhenAll(tasks);
            //}
            //catch (Exception)
            //{
                
            //}      

            try
             {
                
               var task1 = repository.GetSummaryAsync();
                var task2 = repository.GetCountriesAsync();
              

                await Task.WhenAll(task1, task2); // väntar tills alla anrop (tasks) är klar
                

                var summary = await task1;
                var countrie = await task2;
               

                var model = new HomeViewModel(summary);
                // Hanterar resultatet

                return View(model);

            }
            catch (Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Fick inte kontakt med Covidstatistiken. Visar istället gammal statistik.");
                return View(model);
                throw;
            }
          

            
            
           
        }

  

        
    }
}
