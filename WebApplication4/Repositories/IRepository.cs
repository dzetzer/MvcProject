﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        IEnumerable<T> GetByProductID(int id);
    }
}
