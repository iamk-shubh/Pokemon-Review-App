using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IPokemonRepository
    {
        // Returning the list
        ICollection<Pokemon> GetPokemons();

        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);

        bool PokemonExists(int pokeid);       

    }
}
