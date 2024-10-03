using BarcodeGenerator.Application.Contracts.Services;
using BarcodeGenerator.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BarcodeGenerator.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IInventoryVoucherService, InventoryVoucherService>();
        services.AddScoped<ISerialNumberService, SerialNumberService>();

        return services;
    }
}
