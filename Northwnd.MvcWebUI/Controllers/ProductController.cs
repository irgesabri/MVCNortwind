using Northwnd.Bll.Concrete;
using Northwnd.Dal.Concrete.EntittFramework;
using Northwnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager=new ProductManager(new EFProductDal());
        // GET: Product
        public ActionResult Index()
        {
            List<Products> products = _productManager.GetAll();
            return View(products);
        }
    }
}