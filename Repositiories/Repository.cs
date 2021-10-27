using DemoInteraktiva.Infrastructure;
using DemoInteraktiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Repositiories
{
    public class Repository : IRepository
    {
        private readonly IApiClient apiClient;
        private readonly string baseEndpoint = "https://api.covid19api.com/";
        public Repository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        public async Task <SummaryDto> GetSummaryAsync()
        {
            var result = await apiClient.GetAsync<SummaryDto>($"{baseEndpoint}summary");
            return result;
        }

        public async Task<IEnumerable<CountryDto>> GetCountriesAsync() =>  await apiClient.GetAsync<IEnumerable<CountryDto>>($"{baseEndpoint}countries");

        public async Task<IEnumerable<TotalDto>> GetCountryTotal(string countrySlug) => await apiClient.GetAsync<IEnumerable<TotalDto>>($"{baseEndpoint}country/{countrySlug}/status/confirmed");
    }
}
