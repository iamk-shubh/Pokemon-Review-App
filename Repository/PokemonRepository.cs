﻿using Pokemon_Review_App.Data;
using Pokemon_Review_App.Interfaces;
using Pokemon_Review_App.Models;

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
    }
}