using DemoInteraktiva.Models;
using DemoInteraktiva.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Controllers
{
    public class ErikController : Controller
    {

        public IActionResult Index()
        {
            // tre olika s�tt att g� tillv�ga //
            // view data - dictionary // vanligast att anv�nda
            // view bag - dynamisk property // vanligast att anv�nda
            // tempData - session skicka data mellan controllers

            //var people = new List<PersonViewModel>
            //{
            //     new PersonViewModel
            //     {
            //      Firstname = "Jesper",
            //      Lastname = "Thor"
            //     },

            //     new PersonViewModel
            //     {
            //         Firstname = "Felix",
            //         Lastname = "Lidgren"
            //     },
            //};

            
            //ViewData["people"] = people;

            return View();
        }




    }
}
