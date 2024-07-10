using Domain.Entities;

namespace Domain.Interfaces.Persistence
{
    public interface IBasePersistence<T> 
    {
        Task<List<T>> GetRecords();
        Task<T> GetRecord(int id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(int id);
    }
}
