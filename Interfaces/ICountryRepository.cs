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
    }
} 
