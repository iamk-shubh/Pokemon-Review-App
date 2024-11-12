using AutoMapper;
using Pokemon_Review_App.Dto;
using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>(); // after mapping go to CountryController again!!
            CreateMap<Owner, OwnerDto>(); 
            CreateMap<Review, ReviewDto>(); 
            CreateMap<Reviewer, ReviewerDto>(); 
           

            //CreateMap<CategoryDto, Category>();
            //CreateMap<CountryDto, Country>();
            //CreateMap<OwnerDto, Owner>();
            //CreateMap<PokemonDto, Pokemon>();
            //CreateMap<ReviewDto, Review>();
            //CreateMap<ReviewerDto, Reviewer>();
            //CreateMap<Owner, OwnerDto>();
            //CreateMap<Review, ReviewDto>();
            //CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
