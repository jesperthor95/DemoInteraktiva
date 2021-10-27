using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models.ViewModels
{
    public class HomeViewModel
    {
        [DisplayFormat(DataFormatString = "{0:N0} st")]
        [DisplayName("Totalt bekräftade fall")] 
        public int TotalConfirmed { get;}

        [DisplayFormat(DataFormatString = "{0:N0} st")]
        [DisplayName("Totalt bekräftade fall i Sverige")]
        public int TotalConfirmedSweden { get;}
        public HomeViewModel(SummaryDto summary)
        {
            TotalConfirmed = summary.Global.TotalConfirmed;
            var query = summary.Countries
            .Where(x => x.Slug == "sweden")
            .FirstOrDefault();

            TotalConfirmedSweden = query.TotalConfirmed;
        }
        public HomeViewModel()
        {

        }
    }
}
