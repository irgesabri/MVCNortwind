using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;

namespace Northwnd.Dal.Concrete.EntittFramework
{
    public class EFProductDal : IProductDal
    {
        NORTHWNDEntities _context = new NORTHWNDEntities();

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }
        public void Delete(int productId)
        {
            var delete = _context.Products.FirstOrDefault(x=>x.ProductID==productId);
            _context.Products.Remove(delete);
            _context.SaveChanges();

        }
        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(x=>x.ProductID==productId);
        }

        public void Update(Product product)
        {
            var updated = _context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            updated.ProductName = product.ProductName;
            updated.CategoryID = product.CategoryID;
            updated.Discontinued = product.Discontinued;
            updated.QuantityPerUnit = product.QuantityPerUnit;
            updated.SupplierID = product.SupplierID;
            updated.UnitsInStock = product.UnitsInStock;
            updated.UnitsOnOrder = product.UnitsOnOrder;
            _context.SaveChanges();

        }

        List<Product> IProductDal.GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
