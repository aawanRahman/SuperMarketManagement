using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> getTransactionByDay(string cashierName,DateTime dateTime);
        IEnumerable<Transaction> Get(string cashierName);
        void Save(string Cashier_Name, int productId, int BeforeQuantity, int Soldquantity, double Price);
    }
}
