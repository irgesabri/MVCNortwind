using Northwnd.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;
using Northwnd.Interfaces;

namespace Northwnd.Dal.Concrete.EntittFramework
{
    public class EFAuthenticationDal : IAuthenticationDal
    {
        NORTHWNDEntities _context = new NORTHWNDEntities();

        public User Authenticate(User user)
        {
            if (user.UserName=="Sabri" && user.Password=="123")
            {
                return user;
            }
            return null;
        }
    }
}
