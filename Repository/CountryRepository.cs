﻿using AutoMapper;
using Pokemon_Review_App.Data;
using Pokemon_Review_App.Interfaces;
using Pokemon_Review_App.Models;

// Repository is just a fancy word where we put our database calls

namespace Pokemon_Review_App.Repository
{

    // we will have to implement cntrl + . in ICountryRepo as many times we make changes in 
    // in Interface 
    
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        // Created a Constructor and add the datacontext and mapper in constructor
        public CountryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);
        }

        // Post Req Api call 
        public bool CreateCountry(Country country)
        {
            _context.Add(country);
            return Save(); 
        }

        public bool DeleteCountry(Country country)
        {
            _context.Remove(country);
            return Save();
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            // At the end we have used TO.List(); bcoz there could be more than one item
            return _context.Owners.Where(c => c.Country.Id == countryId).ToList();
        }


        // Post req api call 
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateCountry(Country country)
        {
            _context.Update(country);
            return Save();
        }
    }
}
