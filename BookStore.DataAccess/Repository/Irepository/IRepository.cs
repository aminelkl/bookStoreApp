﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.Irepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        T GetFirstOrDefault(Expression<Func<T,bool>> filter);
        void Remove(T entity); 
        void RemoveRange(IEnumerable<T> entity);
    }
}
