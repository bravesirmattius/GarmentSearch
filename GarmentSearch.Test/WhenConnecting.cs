using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using GarmentSearch.Core.Models;

namespace GarmentSearch.Test
{
    [TestClass]
    public class WhenConnecting
    {
        [TestMethod]
        public void ApiConnects()
        {
            string apiURL = "https://sandbox368.bravissimo.site/api/search/xxx";
            UriBuilder builder = new UriBuilder(apiURL);

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(builder.Uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    var userResult = response.Content.ReadAsStringAsync().Result;
                    userResult.Should().NotBeNull();
                }
            }
        }
        [TestMethod]
        public void ApiBringsBack32g()
        {
            string apiURL = "https://sandbox368.bravissimo.site/api/search/32g";
            UriBuilder builder = new UriBuilder(apiURL);
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(builder.Uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    var userResult = response.Content.ReadAsStringAsync().Result;
                    userResult.Should().NotBeNull();
                }
            }
        }

        [TestMethod]
        public void ApiBringsBackGarmentAPIResponse()
        {
            var responseString = GetAThing();
            var response = JsonConvert.DeserializeObject<GarmentApiResponse>(responseString);
            response.Should().BeOfType(typeof(GarmentApiResponse));
        }


        private string GetAThing()
        {
            string apiURL = "https://sandbox368.bravissimo.site/api/search/32g";
            UriBuilder builder = new UriBuilder(apiURL);
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(builder.Uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    return  response.Content.ReadAsStringAsync().Result;
                }
            }
            return string.Empty;
        }

    }
}
