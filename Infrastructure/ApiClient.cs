﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoInteraktiva.Infrastructure
{
    public class ApiClient: IApiClient
    {
        private readonly HttpClient client = new HttpClient();


         public async Task<T> GetAsync<T> (string endpoint)
         {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            
            try
            {
                using var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(responseJson);

                    return data;
                }
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    throw new Exception("Fick ingen kontakt med vårt spel.");
                }
                throw new Exception("´Felaktikgt API-anrop");
                
            }
            catch (Exception)
            {

                throw;
            }
            
         }
    }
}
