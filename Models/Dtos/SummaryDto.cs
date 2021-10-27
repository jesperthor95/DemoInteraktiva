using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models
{
    public class SummaryDto
    {

        public GlobalDto Global { get; set; }
        public List<CountryDto> Countries { get; set; }

    }
}
