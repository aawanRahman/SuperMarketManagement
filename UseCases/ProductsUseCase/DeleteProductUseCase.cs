using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.ProductsUseCase
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private IProductRepository productRepository;
        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }
        public void deleteProduct(int id)
        {

            var product = productRepository.GetProductById(id);
            productRepository.deleteProduct(product);

        }
    }
}
