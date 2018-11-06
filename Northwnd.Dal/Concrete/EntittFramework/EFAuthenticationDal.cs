using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;

namespace Northwnd.Dal.Concrete.EntittFramework
{
    public class EFAuthenticationDal : IAuthenticationDal
    {
        public User Authenticate(User user)
        {
            throw new NotImplementedException();
        }
    }
}
