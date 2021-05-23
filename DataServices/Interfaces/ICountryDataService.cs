using System.Threading.Tasks;
using CricketStats_Frontend.Models;

namespace CricketStats_Frontend.DataServices.Interfaces
{

    public interface ICountryDataService

    {

           Task<Country[]> GetAllCountries(); 

    }


}