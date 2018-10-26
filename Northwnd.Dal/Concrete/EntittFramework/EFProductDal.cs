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

        public void Add(Products product)
        {
            throw new NotImplementedException();
        }
        public void Delete(Products product)
        {
            throw new NotImplementedException();
        }
        public Products Get(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Products product)
        {
            throw new NotImplementedException();
        }

        List<Products> IProductDal.GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
