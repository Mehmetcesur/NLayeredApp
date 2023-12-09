using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess;
using Core.Persistence.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ProductManager : IProductService
{
    IProductDal _productDal;
    IMapper _mapper;
    public ProductManager(IProductDal productDal,IMapper mapper)
    {
        _productDal = productDal;
        _mapper = mapper;

    }


    public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
    {
        Product product = _mapper.Map<Product>(createProductRequest);
        Product createdProduct = await _productDal.AddAsync(product);
        CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(createdProduct);
        return createdProductResponse;
    }

    public async Task<GetListProductResponse> GetListAsync()
    {
        IPaginate<Product> products = await _productDal.GetListAsync();
        GetListProductResponse mapped = _mapper.Map<GetListProductResponse>(products);
        return mapped;
    }
}