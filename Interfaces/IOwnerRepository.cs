using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        
        // post
        bool CreateOwner(Owner owner);

        // put and delete 
        bool UpdateOwner(Owner owner);
        bool DeleteOwner(Owner owner);

        bool Save();
    }
}
