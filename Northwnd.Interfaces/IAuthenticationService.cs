using Northwnd.Entities;
using System.ServiceModel;

namespace Northwnd.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {       
        [OperationContract]
        User Authenticate(User user);
    }
}