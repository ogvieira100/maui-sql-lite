using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sql_lite.Repository
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
    public interface IBaseRepository<T> : IDisposable
          where T : TableData, new()
    {
        void Update(T item);
        void insert(T item);
        T GetItem(int id);
        T GetItem(Expression<Func<T, bool>> predicate);
        List<T> GetItems();
        List<T> GetItems(Expression<Func<T, bool>> predicate);
        void DeleteItem(T item);
    }
}
