
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models.ViewModels
{
    public class ErikViewModel
    {

        public List<PersonViewModel> People { get; set; }

        public DateTime CreationDate {get; set;}

        public string Author { get; set; }

    }
}

