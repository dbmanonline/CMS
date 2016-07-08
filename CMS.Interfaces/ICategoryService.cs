﻿using CMS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
    }
}
