using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.Persistence.Paging;
using Entities.Concretes;

namespace Business.Dtos.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<Category, CreatedCategoryResponse>();

        }
    }
}
