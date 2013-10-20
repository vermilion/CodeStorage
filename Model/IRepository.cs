using System.Linq;

namespace Model
{
    public interface IRepository
    {
        IQueryable<T> GetAll<T>();
        void Save<T>(T entity);
        void Delete<T>(T entity); 
    }
}