﻿using Northwnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
    }
}
