using GarmentSearch.Core.Interfaces;
using GarmentSearch.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GarmentSearch.Service.Garments
{
    public class GarmentSearchService : IGarmentSearchService
    {
        public GarmentSearchService()
        {

        }

        public IEnumerable<Garment> SearchGarment(string searchCriteria)
        {
            string apiURL = "https://sandbox368.bravissimo.site/api/search/32g";
            UriBuilder builder = new UriBuilder(apiURL);
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(builder.Uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var garmentResponse = JsonConvert.DeserializeObject<GarmentApiResponse>(responseString);
                    return garmentResponse.Items;
                }
            }
            return default(IEnumerable<Garment>);
        }
    }
}
