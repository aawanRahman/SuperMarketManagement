using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.TransactionsUseCase
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private ITransactionRepository transactionRepository;

        private IProductRepository productRepository;
        public RecordTransactionUseCase(ITransactionRepository transactionRepository, IProductRepository productRepository)
        {
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;

        }
        public void execute(string cahier_name, int productId, int quantity)
        {
            var product = productRepository.GetProductById(productId);
            transactionRepository.Save(cahier_name, productId, product.Quantity.Value, quantity, quantity * product.Price.Value);


        }
    }
}
