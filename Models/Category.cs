﻿namespace Pokemon_Review_App.Models
{
    // Sent to Category Dto in Dto Folder to copy there 
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
