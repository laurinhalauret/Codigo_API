using System.Collections.Generic;

namespace MeuProjetoAPI.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T Get(int id)
        {
            // Implementação simplificada para exemplo
            return _entities[id];
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public void Update(T entity)
        {
            // Implementação simplificada para exemplo
        }

        public void Delete(int id)
        {
            _entities.RemoveAt(id);
        }
    }
}
