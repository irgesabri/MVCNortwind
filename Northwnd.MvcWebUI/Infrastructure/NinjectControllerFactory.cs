using Ninject;
using Northwnd.Bll.Concrete;
using Northwnd.Dal.Concrete.EntittFramework;
using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Northwnd.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        //kontrol uretici
        //senin cons senden su cons isterse onu devreye sok.
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EFProductDal());
            //birisi senden Iproductservice isterse sen ona ProductManager ı ver.

            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EFCategoryDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }

    }
}