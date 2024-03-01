using AutoMapper;
using InventoryProject.Application.Commands;
using InventoryProject.Application.Responses;
using InventoryProject.Core.Entities;

namespace InventoryProject.Application.Mappers
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CreateCategoryResponse>().ReverseMap();
            CreateMap<Category, GetCategoryByCategoryNameResponse>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }
    }
}
