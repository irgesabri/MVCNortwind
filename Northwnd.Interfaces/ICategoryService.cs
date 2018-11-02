using Northwnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Interfaces
{
    [ServiceContract]
   public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();
    }
}
