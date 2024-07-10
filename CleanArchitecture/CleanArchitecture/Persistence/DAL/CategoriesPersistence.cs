using Domain.Entities;
using Domain.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using Persistence.Utilities;

namespace Persistence.DAL
{
    public class CategoriesPersistence : BasePersistence, ICategoriesPersistence
    {
        private readonly DatabaseContext _context;
        public CategoriesPersistence(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Categories>> GetRecords()
        {
            var result = await _context.Categories.ToListAsync();
            return result;
        }
        public async Task<Categories> GetRecord(int id)
        {
            var result = await _context.Categories.Where(x => x.CategoryID == id)
                                                  .FirstAsync();
            return result;
        }

        public async Task<int> Insert(Categories entity)
        {
            var result = await InsertToDB(_context ,entity);
            return result;
        }

        public async Task<int> Update(Categories entity)
        {
            var categories = await _context.Categories.FindAsync(entity.CategoryID);
            categories.CategoryName = entity.CategoryName;
            int result = await _context.SaveChangesAsync();
            return result;
            
        }
        public async Task<int> Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            int result = await _context.SaveChangesAsync();
            return result;
        }
    }
}
