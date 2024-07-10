
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Persistence.Utilities
{
    public class BasePersistence
    {
        protected async Task<int> InsertToDB<T>(DatabaseContext context, T entity) where T : class
        {
            var newEntity = context.Set<T>().AddAsync(entity);
            int result = await context.SaveChangesAsync();
            return result;
        }
    }
}
