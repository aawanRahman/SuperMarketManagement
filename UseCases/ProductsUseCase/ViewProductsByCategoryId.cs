using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.ProductsUseCase
{
    public class ViewProductsByCategoryId : IViewProductsByCategoryId
    {

        public IProductRepository productRepository;
        public ViewProductsByCategoryId(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> VewProductsByCategoryId(int categoryId)
        {
            return productRepository.getProductsByCategoryId(categoryId);
        }
    }
}
