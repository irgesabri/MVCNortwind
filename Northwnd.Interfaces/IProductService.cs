using Northwnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Northwnd.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product Get(int productId);
        void Add(Product product);
        [OperationContract]
        void Delete(int productId);
        [OperationContract]
        void Update(Product product);
    }
}
