using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwnd.Entities;

namespace Northwnd.Interfaces
{
    public interface IAuthenticationService
    {
        User Authenticate(User user);
    }
}
