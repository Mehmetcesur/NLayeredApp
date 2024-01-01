using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ProductBusinessRules : BaseBusinessRules
    {
        private readonly IProductDal _productDal;

        public ProductBusinessRules(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task MaximumProductCountIsTwenty  (int categoryid)
        {
            var result = await _productDal.GetListAsync(
                
                predicate:p=>p.CategoryId==categoryid,
                size:25
                );
            if (result.Count >= 20)
            {
                throw new BusinessException(BusinessMessages.ProductLimit);
            }

        }


    }
}
