

namespace Domain.Interfaces.Application
{
    public interface IBaseApplication<T>
    {
        Task<List<T>> GetRecords();
        Task<T> GetRecord(int id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(int id);
    }
}
