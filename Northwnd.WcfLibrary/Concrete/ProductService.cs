using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;
using Northwnd.Bll.Concrete;
using Northwnd.Dal.Concrete.EntittFramework;

namespace Northwnd.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        //instance provider ile ezilecek.
        ProductManager _productManager = new ProductManager(new EFProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }

    }
}
