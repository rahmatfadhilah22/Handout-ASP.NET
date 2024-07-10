using Application.BusinessLogic;
using Domain.Interfaces.Application;
using Domain.Interfaces.Persistence;
using Persistence.DAL;

namespace Infrastructure.ScopeRegister
{
    public class ScopeRegister
    {
        public static void AddScopes(IServiceCollection services)
        {
            services.AddScoped<ICategoriesPersistence, CategoriesPersistence>();
            services.AddScoped<ICategoriesApplication, CategoriesApplication>();
        }
    }
}
