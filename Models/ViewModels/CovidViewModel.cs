using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models.ViewModels
{
    public class CovidViewModel
    {
        private readonly IEnumerable<CountryDto> countries;
        
        public string SelectedCountry { get; set; }
        public IEnumerable<SelectListItem> Countries 
        {
            get
            {
                if(countries != null)
                {
                    return countries.Select(x =>
                           new SelectListItem()
                           {
                               Text = x.Country,
                               Value = x.Slug
                           });
                }
                return null;
            }
        }
        public CovidViewModel(IEnumerable<CountryDto> countries)
        {
            this.countries = countries.OrderBy(x => x.Country);
        }
    }
}
