namespace MeuProjetoAPI.Services
{
    public interface IService<T>
    {
        void Validate(T entity);
        // Outros m�todos de servi�o
    }
}
