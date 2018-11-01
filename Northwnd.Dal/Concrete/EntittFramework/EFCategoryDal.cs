using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;

namespace Northwnd.Dal.Concrete.EntittFramework
{
    public class EFCategoryDal : ICategoryDal
    {
        NORTHWNDEntities _context = new NORTHWNDEntities();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
