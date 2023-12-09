using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.Persistence.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<GetListProductResponse> GetListAsync();
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);                         
    }
}
