namespace BarcodeGenerator.Application.Contracts.SendSMS;

public interface ISendSmsService
{
    void Send(string phoneNumber, string message);
}
