namespace MeuProjetoAPI.Services
{
    public interface IService<T>
    {
        void Validate(T entity);
        // Outros métodos de serviço
    }
}
