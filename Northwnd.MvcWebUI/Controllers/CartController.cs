using Northwnd.Entities;
using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Cart
        public ActionResult AddToCart(int productId)
        {
            Product product = _productService.Get(productId);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }

            cart.AddToCart(product, 1);
            return View("Index",cart);
        }
    }
}