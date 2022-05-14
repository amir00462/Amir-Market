using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmirMarket.DAL;
using AmirMarket.Entities;

namespace AmirMarket.BLL
{
    public class ProductManager
    {
        ProductDao productDao = new ProductDao();

        public List<Product> GetAllProducts()
        {
            return productDao.GetAllProducts();
        }

        public void AddToDatabase(Product product)
        {
            productDao.AddToDatabase(product);
        }

        public void RemoveFromDatabase(string name)
        {
            productDao.RemoveFromDatabase(name);
        }


    }
}
