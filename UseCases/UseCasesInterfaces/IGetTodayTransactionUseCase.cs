using CoreBusiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IGetTodayTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}