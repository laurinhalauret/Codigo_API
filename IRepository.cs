using System.Collections.Generic;

namespace MeuProjetoAPI.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
