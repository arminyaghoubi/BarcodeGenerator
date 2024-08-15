using BarcodeGenerator.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BarcodeGenerator.Persistence;

public static class PersistenceServiceRegistration
{
	public static IServiceCollection AddPersistenceServices(this IServiceCollection services,string connectionString)
	{
		services.AddDbContext<BarcodeGeneratorDbContext>(options=>options.UseSqlServer(connectionString));

		return services;
	}
}
