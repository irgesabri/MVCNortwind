using Northwnd.Bll.Concrete;
using Northwnd.Dal.Concrete.EntittFramework;
using Northwnd.Entities;
using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        //ProductManager _productManager=new ProductManager(new EFProductDal());
        private IProductService _productservice;
        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = _productservice.GetAll();
            return View(products);
        }
    }
}