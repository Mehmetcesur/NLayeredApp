﻿using Azure;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
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
        Task<IPaginate<GetListProductResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
        Task<CreatedProductResponse> GetByProductName(string name);

    }
}
