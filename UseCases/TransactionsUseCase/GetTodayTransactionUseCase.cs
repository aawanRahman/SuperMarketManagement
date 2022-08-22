using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.TransactionsUseCase
{
    public class GetTodayTransactionUseCase : IGetTodayTransactionUseCase
    {
        private ITransactionRepository transactionRepository;
        public GetTodayTransactionUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return transactionRepository.getTransactionByDay(cashierName, DateTime.Now);
        }
    }
}
