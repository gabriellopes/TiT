namespace TiT.Comum
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : Entity
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase repository) {
            _repository = repository;
        }

        T Get(int id) {
            return _repository.Get(id);
        }

        bool Add(T entity)  {
            return _repository.Add(entity);
        }

        bool RemoveById(int id) {
            return _repository.RemoveById(id);
        }

        bool Remove(T entity) {
            return _repository.Remove(T);
        }

        
    }
}