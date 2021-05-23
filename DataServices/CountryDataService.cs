using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CricketStats_Frontend.DataServices.Interfaces;
using CricketStats_Frontend.DTO;
using CricketStats_Frontend.Models;

namespace CricketStats_Frontend.DataServices
{

    public class CountryDataService: ICountryDataService
    {
        private readonly HttpClient _httpClient;

        public CountryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;    
        }

        async public Task<Country[]> GetAllCountries() {
           var queryObject = new {
               query = @"query{  country{    id    countryCode    countryDesc    lastUpdated }}",
               variables = new {}
           };

            var launchQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json"
            );

          var response =  await  _httpClient.PostAsync("graphql", launchQuery);

          if(response.IsSuccessStatusCode){
             var gqlData =  await JsonSerializer.DeserializeAsync<GqlData>(await response.Content.ReadAsStreamAsync());
             return gqlData.Data.Countries;
          }

          return null;

        }

    }

}