﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.TransactionsUseCase
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private ITransactionRepository transactionRepository;
        public GetTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return transactionRepository.getTransactionByDayRange(cashierName, startDate, endDate);

        }
    }
}
