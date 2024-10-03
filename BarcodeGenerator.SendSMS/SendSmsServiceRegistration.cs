using BarcodeGenerator.Application.Contracts.SendSMS;
using BarcodeGenerator.SendSMS.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BarcodeGenerator.SendSMS;

public static class SendSmsServiceRegistration
{
    public static IServiceCollection AddSendSmsServices(this IServiceCollection services)
    {
        services.AddScoped<ISendSmsService, SendSmsService>();

        return services;
    }
}
