using System.Threading.Tasks;
using CricketStats_Frontend.DataServices.Interfaces;
using CricketStats_Frontend.Models;
using Microsoft.AspNetCore.Components;

namespace CricketStats_Frontend.Pages
{
    public partial class Countries 
    {
        [Inject]
        ICountryDataService CountryDataService {get; set;}

        private Country[] countries;

        protected override async Task OnInitializedAsync()
        {
            countries  = await CountryDataService.GetAllCountries();
        }
        
    }
}