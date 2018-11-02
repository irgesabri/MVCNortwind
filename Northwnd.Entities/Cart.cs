using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entities
{
    public class Cart
    {
        List<CartLine> _lines = new List<CartLine>();

        public void AddToCart(Product product, int quantity)
        {

            CartLine cartline = _lines.FirstOrDefault(x=>x.Product.ProductID==product.ProductID);
            if (cartline==null)
            {
                _lines.Add(new CartLine { Product = product, quantity = quantity });
            }
            else
            {
                cartline.quantity += quantity;
            }
        }

        public void Clear()
        {
            _lines.Clear();
        }

        public List<CartLine> Lines
        {
            get { return _lines; }
        }

        public void RemoveFromCart(Product product)
        {
            _lines.RemoveAll(x => x.Product.ProductID == product.ProductID);
        }

        public decimal Total
        {
            get { return (decimal)_lines.Sum(x => x.Product.UnitPrice * x.quantity); }
        }
    }




    public class CartLine
    {
        public int quantity;

        public Product Product { get; internal set; }
    }
}
