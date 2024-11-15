﻿using Pokemon_Review_App.Data;
using Pokemon_Review_App.Interfaces;
using Pokemon_Review_App.Models;
using System.Diagnostics.Metrics;

namespace Pokemon_Review_App.Repository
{
    // ??????????????????????????????
    public class PokemonRepository : IPokemonRepository
    {
        public readonly DataContext _context;
        public PokemonRepository(DataContext Context)
        {
            _context = Context;
        }


        // post req call
        public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            var pokemonOwnerEntity = _context.Owners.Where(a => a.Id == ownerId)
                    .FirstOrDefault();
            
            var category = _context.Categories.Where(a => a.Id == categoryId)
                    .FirstOrDefault();

            var pokemonOwner = new PokemonOwner()
            {
                Owner = pokemonOwnerEntity,
                Pokemon = pokemon,
            }; 
            // adding
            _context.Add(pokemonOwner);


            var pokeCategory = new PokemonCategory()
            {
                Category = category,
                Pokemon = pokemon
            };
            // adding
            _context.Add(pokeCategory);
            _context.Add(pokemon);

            return Save();


        }

        public bool DeletePokemon(Pokemon pokemon)
        {
            _context.Remove(pokemon);
            return Save();
        } 

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);

            if(review.Count() <= 0)
                return 0;
      

            return ( (decimal)review.Sum(r => r.Rating) / review.Count() );
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemon.Any(p => p.Id == pokeid);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            _context.Update(pokemon);
            return Save();
        }
    }
}
