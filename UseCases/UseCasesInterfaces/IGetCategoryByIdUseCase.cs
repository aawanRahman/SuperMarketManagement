using CoreBusiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category getCategorybyId(int id);
    }
}