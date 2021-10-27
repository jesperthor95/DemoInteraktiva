using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models
{
    public class CountryDto
    {
        public string Country { get; set; }
        public string Slug { get; set; }
        public int TotalConfirmed { get; set; }
        public DateTime Date { get; set; }

    }
}
