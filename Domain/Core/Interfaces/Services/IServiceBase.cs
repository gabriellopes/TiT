namespace TiT.Comum.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        bool Add(T entity);

        bool Remove(T entity);

        bool RemoveById(int id);

        T Get(int id);
    }
}