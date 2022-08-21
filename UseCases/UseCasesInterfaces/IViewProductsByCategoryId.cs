using CoreBusiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> VewProductsByCategoryId(int categoryId);
    }
}