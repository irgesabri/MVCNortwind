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
        public ActionResult AddToCart(Cart cart, int productId)
        {
            //paremtre ekle yukarıya Cart cart
            Product product = _productService.Get(productId);
            //var cart = (Cart)Session["cart"];
            //if (cart == null)
            //{
            //    cart = new Cart();
            //    Session["cart"] = cart;
            //}

            cart.AddToCart(product, 1);
            return View("Index", cart);
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId)
        {
            Product product = _productService.Get(productId);
            //var cart = (Cart)Session["cart"];
            //if (cart.Lines.Count == 0)
            //{
            //    ModelState.AddModelError("", "Sepette Ürün Yok");
            //}
            //else
            //{
            //    
            //}
            cart.RemoveFromCart(product);
            return RedirectToAction("Index", cart);
        }
        public ActionResult Index(Cart cart)
        {
            //var cart = (Cart)Session["cart"];
            return View(cart);
        }
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippindetail)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Completed");
            }
            else
            {
                return View(shippindetail);
            }

        }
        public ActionResult Completed()
        {
            return View();
        }
        public PartialViewResult CartSummary(Cart cart)
        {
            //var cart = (Cart)Session["cart"];
            //if (cart == null)
            //{
            //    cart = new Cart();
            //}
            return PartialView(cart);
        }


    }
}