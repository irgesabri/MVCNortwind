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
        List<Products> GetAll();
        [OperationContract]
        Products Get(int productId);
        void Add(Products product);
        [OperationContract]
        void Delete(int productId);
        [OperationContract]
        void Update(Products product);
    }
}
