using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;
using Northwnd.Dal.Abstract;

namespace Northwnd.Bll.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        private IAuthenticationDal _aututhenticationDal;
        public AuthenticationManager(IAuthenticationDal aututhenticationDal)
        {
            _aututhenticationDal = aututhenticationDal;
        }
        public User Authenticate(User user)
        {
            return _aututhenticationDal.Authenticate(user);
        }
    }
}
