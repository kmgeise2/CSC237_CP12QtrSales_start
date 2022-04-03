using System.Collections.Generic;

namespace CSC237_CP12QtrSales_start.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
