using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Movies.Models;

namespace Movies.Repository
{
    public class MovieRepository<T> : IMovieRepository<T> where T : class
    {
        private readonly MoviesDbContext db;
        private readonly DbSet<T> dbset;

        public MovieRepository()
        {
            db = new MoviesDbContext();
            dbset = db.Set<T>();
        }

        public void Delete(object id)
        {
            T entity = dbset.Find(id);
            dbset.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetById(object id)
        {
            return dbset.Find(id);
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}