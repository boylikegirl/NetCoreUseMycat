using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T:class
    {
        ApplicationDbContext _context;
        private bool isTran = false;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void BeginTrains()
        {
            isTran = true;
        }
        public int Commit()
        {
            return _context.SaveChanges();
            
        }
        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList(string sql)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            _context.Add(entity);
            if (!isTran)
            {

                return Commit();
            }
            else
            {
                return 0;
            }
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetModel(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
