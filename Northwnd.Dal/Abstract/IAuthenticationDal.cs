using Northwnd.Entities;

namespace Northwnd.Dal.Abstract
{
    public interface IAuthenticationDal
    {
        User Authenticate(User user);
    }
}