using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId); 
        bool CategoryExists(int id);

        // Post
        bool CreateCategory(Category category);

        // Update / Put method
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);

        bool Save();

        

    }
}
