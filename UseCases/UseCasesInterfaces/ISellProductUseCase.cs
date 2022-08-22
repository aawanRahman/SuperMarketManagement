namespace UseCases.UseCasesInterfaces
{
    public interface ISellProductUseCase
    {
        void execute(string cahierName, int productId, int quantityToSell);
    }
}