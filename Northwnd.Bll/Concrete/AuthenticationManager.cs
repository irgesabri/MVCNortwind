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
        private IAuthenticationDal _authenticationDal;
        public AuthenticationManager(IAuthenticationDal authenticationDal)
        {
            _authenticationDal = authenticationDal;
        }
        public User Authenticate(User user)
        {
            return _authenticationDal.Authenticate(user);
        }
    }
}
