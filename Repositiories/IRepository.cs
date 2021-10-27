using DemoInteraktiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Repositiories
{
    public interface IRepository
    {
      
        Task<SummaryDto> GetSummaryAsync();
        Task<IEnumerable<CountryDto>> GetCountriesAsync();
        Task<IEnumerable<TotalDto>> GetCountryTotal(string countrySlug);
    }
}
