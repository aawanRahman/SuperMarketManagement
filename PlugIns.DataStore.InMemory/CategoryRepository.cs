using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace PlugIns.DataStore.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> categories;
        public CategoryRepository()
        {
            //Add some Default Categories.

            categories = new List<Category>()
            {
                new Category() {Id=1, Name = "Irish Whiskry", Description = "Bevarage" },
                new Category() {Id=2, Name = "Bakery", Description = "Bakery" },
                new Category() {Id=3, Name = "Okra", Description = "Vegetables" },
                new Category() {Id=4, Name = "Jin", Description = "Bevarage" },
                new Category() {Id=5, Name = "Meat", Description = "Meat" },
                new Category() {Id=6, Name = "Onion", Description = "Vegetables" },
                new Category() {Id=7, Name = "Burger", Description = "Fast Food" },
                
            
            
            };
        }

        public void addCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (categories != null && categories.Count > 0)
            {
                var id = categories.Max(x => x.Id);
                category.Id = id + 1;
                categories.Add(category);
            }
            else
            {
                category.Id =  1;
                categories.Add(category);
            }

        }

        public void deleteCategory(Category category)
        {
            var deletedcategory = categories?.FirstOrDefault(n => n.Id == category.Id);
            if(categories!= null && deletedcategory!= null)  categories.Remove(deletedcategory);
            
        }

        public void editCategory(Category category)
        {
            var editedCategory = categories?.FirstOrDefault(n => n.Id == category.Id);
            if(editCategory != null)
            {
                editedCategory.Name = category.Name;
                editedCategory.Description = category.Description;
                editedCategory.Id = category.Id;
            }

        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
            
        }

        public Category getCategoryById(int id)
        {
            return categories?.FirstOrDefault(x => x.Id == id);
           
        }
    }
}
