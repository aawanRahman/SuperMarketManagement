using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace PlugIns.DataStore.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){ Id =1, CategoryId = 1, Name = "Tea",Quantity =10, Price = 10.20},
                new Product(){ Id =2, CategoryId = 2, Name = "Meat",Quantity =15, Price = 10.20},
                new Product(){ Id =3, CategoryId = 1, Name = "Coffee",Quantity =40, Price = 20.20},
                new Product(){ Id =4, CategoryId = 3, Name = "mango",Quantity =21, Price = 11.20},

            };

        }

        public void addNewProduct(Product product)
        {
            if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (_products != null && product != null && _products.Count>0)
            {
                var id = _products.Max(p => p.Id);
                product.Id = id+1;
            }
            else
            {
                product.Id = 1;
            }
            _products.Add(product);
        }

        public void deleteProduct(Product product)
        {
            _products.Remove(product);
        }

        public void editProduct(Product product)
        {
            var editedProduct = _products?.FirstOrDefault(n => n.Id == product.Id);
            if(editedProduct != null)
            {
                editedProduct.Name = product.Name;
                editedProduct.Price = product.Price;
                editedProduct.Quantity = product.Quantity;
                editedProduct.CategoryId = product.CategoryId;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            var product = _products?.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public IEnumerable<Product> getProductsByCategoryId(int categoryId)
        {
           return _products?.Where(x => x.CategoryId == categoryId);
           
        }

        public void UpdateProduct(Product product)
        {
            var editedProduct = _products?.FirstOrDefault(n => n.Id == product.Id);
            if (editedProduct != null)
            {
                editedProduct.Name = product.Name;
                editedProduct.Price = product.Price;
                editedProduct.Quantity = product.Quantity;
                editedProduct.CategoryId = product.CategoryId;
            }
        }
    }
}
