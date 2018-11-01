using Northwnd.Bll.Concrete;
using Northwnd.Dal.Concrete.EntittFramework;
using Northwnd.Entities;
using Northwnd.Interfaces;
using Northwnd.MvcWebUI.Models;
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
        public int PageSize = 5;

        // GET: Product
        public ActionResult Index(int page = 1)
        {
            List<Product> products = _productservice.GetAll();
            return View(new ProductViewModel
            {
                Product = products.Skip((page - 1) * PageSize).Take(5).ToList(),
                PageInfo = new PageInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrrentPage = page
                }
            });
        }
    }
}