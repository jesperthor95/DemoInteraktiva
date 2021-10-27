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
            // tre olika sätt att gå tillväga //
            // view data - dictionary // vanligast att använda
            // view bag - dynamisk property // vanligast att använda
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
