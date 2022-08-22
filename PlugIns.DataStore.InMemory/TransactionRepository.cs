using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace PlugIns.DataStore.InMemory
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> _transactions;

        public TransactionRepository()
        {
            _transactions = new List<Transaction>();   
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if(string.IsNullOrEmpty(cashierName)) return _transactions;
            else return _transactions.Where(x=> string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Transaction> getTransactionByDay(string cashierName, DateTime dateTime)
        {
            if (string.IsNullOrEmpty(cashierName)) 
                return _transactions.Where(x => x.TimeStamp.Date == dateTime.Date);
            else
            {
                return _transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) && x.TimeStamp.Date == dateTime.Date);
            }
           
        }

        public IEnumerable<Transaction> getTransactionByDayRange(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrEmpty(cashierName))
                return _transactions.Where(x => x.TimeStamp.Date >= startDate.Date && x.TimeStamp.Date <= endDate.Date);
            else
            {
                return _transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) && x.TimeStamp.Date >= startDate.Date && x.TimeStamp.Date <= endDate.Date);
            }


        }

        public void Save(string Cashier_Name, int prdctId, int BeforeQuantity, int Soldquantity, double Price)
        {
            int transactionId;
            if (_transactions != null && _transactions.Count > 0)
            {
                transactionId = _transactions.Max(x => x.Id) + 1;

            }
            else transactionId = 1;
            
            

            _transactions.Add(
                new Transaction()
                {
                    Id = transactionId,
                    TimeStamp = DateTime.Now,
                    ProductId = prdctId,
                    SoldQuantity = Soldquantity,
                    Price = Price,
                    BeforeQuantity = BeforeQuantity,
                    CashierName = Cashier_Name
                });
        }
    }
}
