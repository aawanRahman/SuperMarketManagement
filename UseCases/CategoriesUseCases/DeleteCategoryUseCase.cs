using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private ICategoryRepository categoryRepository;
        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;

        }
        public void DeleteCategory(int id)
        {
            var category = categoryRepository.getCategoryById(id);
            categoryRepository.deleteCategory(category);

        }

    }
}
