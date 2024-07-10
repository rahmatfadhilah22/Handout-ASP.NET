using Domain.Entities;
using Domain.Interfaces.Application;
using Domain.Interfaces.Persistence;

namespace Application.BusinessLogic
{
    public class CategoriesApplication : ICategoriesApplication
    {
        private readonly ICategoriesPersistence _persistence;
        public CategoriesApplication(ICategoriesPersistence presistence)
        {
            _persistence = presistence;
        }
        public async Task<List<Categories>> GetRecords()
        {
           return await _persistence.GetRecords();
        }
        public async Task<Categories> GetRecord(int id)
        {
            return await _persistence.GetRecord(id);
        }
        public async Task<int> Insert(Categories entity)
        {
            return await _persistence.Insert(entity);
        }

        public async Task<int> Update(Categories entity)
        {
            return await _persistence.Update(entity);
        }
        public async Task<int> Delete(int id)
        {
            return await _persistence.Delete(id);
        }
        
    }
}
