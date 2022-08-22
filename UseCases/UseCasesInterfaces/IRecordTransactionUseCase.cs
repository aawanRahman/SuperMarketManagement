namespace UseCases.UseCasesInterfaces
{
    public interface IRecordTransactionUseCase
    {
        void execute(string cahier_name, int productId, int quantity);
    }
}