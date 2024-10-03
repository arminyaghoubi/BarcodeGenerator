using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Persistence.Contexts;
using BarcodeGenerator.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BarcodeGenerator.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<BarcodeGeneratorDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IInventoryVoucherRepository, InventoryVoucherRepository>();
        //services.AddScoped<IInventoryVoucherRepository, InventoryVoucherRepositoryMongoDB>();

        services.AddScoped<IInventoryVoucherSerialNumberRepository, InventoryVoucherSerialNumberRepository>();

        return services;
    }
}
