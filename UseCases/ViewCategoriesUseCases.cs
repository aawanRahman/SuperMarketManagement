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
    public class ViewCategoriesUseCases : IViewCategoriesUseCases
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUseCases(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();



        }
    }
}
