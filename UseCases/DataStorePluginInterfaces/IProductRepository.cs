using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void addNewProduct(Product product);
        void editProduct(Product product);
        void deleteProduct(Product product);
        IEnumerable<Product> getProductsByCategoryId(int categoryId);
        void UpdateProduct(Product product);
    }
}
