using LibraryProject.MvcWebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        LibraryContext context = new LibraryContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();

            //context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}