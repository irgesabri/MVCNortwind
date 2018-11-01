using System.Collections.Generic;
using Northwnd.Entities;

namespace Northwnd.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Product { get; set; }
    }
}