using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.Persistence.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Profiles
{
    public class ProductMappingProfile:Profile
    {
        public ProductMappingProfile()
        {

            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreatedProductResponse>();
            //GetListResponse İçin

            CreateMap<Product, GetListProductResponse>().ForMember(destinationMember: p => p.CategoryName, memberOptions: opt => opt.MapFrom(p => p.Category.Name)).ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>();
            CreateMap<UpdateProductRequest, Product>();

        }
    }
}
