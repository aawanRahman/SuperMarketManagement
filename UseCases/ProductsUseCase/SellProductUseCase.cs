using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.ProductsUseCase
{
    public class SellProductUseCase : ISellProductUseCase
    {
        public IProductRepository productRepository;
        private IRecordTransactionUseCase recordTransactionUseCase;
        public SellProductUseCase(IProductRepository productRepository, IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }
        public void execute(string cahierName, int productId, int quantityToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;
            product.Quantity -= quantityToSell;
            productRepository.UpdateProduct(product);
            recordTransactionUseCase.execute(cahierName, productId, quantityToSell);


        }
    }
}
