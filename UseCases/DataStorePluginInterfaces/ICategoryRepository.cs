using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public void addCategory(Category category);
        public void editCategory(Category category);
        public Category getCategoryById(int id);
        public void deleteCategory(Category category);

    }
}
