using System.Data.Entity

namespace Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        private readonly DataContext _data_context;

        public RepositoryBase(DataContext data_context) {
            _data_context = data_context;
        }
        
        bool Add(T entity) {
            
        }
    }
}