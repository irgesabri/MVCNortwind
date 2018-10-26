using Northwnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Abstract
{
    public interface IProductDal
    {
        List<Products> GetAll();
        Products Get(int productId);
        void Add(Products product);
        void Delete(Products product);
        void Update(Products product);
    }
}
