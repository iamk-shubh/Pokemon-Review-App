using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{

    // This are the functions which we want in out api or api call
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);

        // Created the calls for Post request 
        // Now go to inteface and you will se the red wavyy lines on ICountryRepo ->
        // Implement the interface again 
        bool CreateCountry(Country country);
        bool Save();


        // Creating put and delete methods
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
    }
} 
