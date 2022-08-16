using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases
{
    public class addCategoryUseCase : IaddCategoryUseCase
    {
        private ICategoryRepository categoryRepository;
        public addCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void addNewCategory(Category category)
        {
            categoryRepository.addCategory(category);
        }
    }
}
