using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class editCategoryUseCase : IeditCategoryUseCase
    {
        private ICategoryRepository categoryRepository;
        public editCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void editCategory(Category category)
        {
            categoryRepository.editCategory(category);

        }
    }
}
