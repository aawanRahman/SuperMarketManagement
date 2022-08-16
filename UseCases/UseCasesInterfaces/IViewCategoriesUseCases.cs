using CoreBusiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IViewCategoriesUseCases
    {
        IEnumerable<Category> Execute();
    }
}