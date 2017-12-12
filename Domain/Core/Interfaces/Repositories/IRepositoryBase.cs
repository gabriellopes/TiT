namespace TiT.Comum.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : Entity
    {
        bool Add(T entity);

        bool Remove(T entity);

        bool RemoveById(int id);

        T Get(int id);
    }
}