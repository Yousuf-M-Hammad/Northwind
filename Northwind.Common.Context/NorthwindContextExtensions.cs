using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Common.Context
{
    static public class NorthwindContextExtensions
    {
        public static IServiceCollection AddNorthwindContext(this IServiceCollection services) {
            services.AddDbContext<NorthwindDB>(builder => builder.UseSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=true;Encrypt=false"));
            return services;
        }
    }
}
