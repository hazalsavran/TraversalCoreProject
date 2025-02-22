using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByID(int id);
        List<T> GetAll();
        List<T> GetListByFilter(Expression<Func<T,bool>> filter);

    }
}
