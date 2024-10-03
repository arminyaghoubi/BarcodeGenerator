using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Application.Contracts.SendSMS;
using BarcodeGenerator.Application.Contracts.Services;
using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Services;

public class InventoryVoucherService : IInventoryVoucherService
{
    private readonly IInventoryVoucherRepository _inventoryVoucherRepository;
    private readonly ISendSmsService _sendSmsService;

    public InventoryVoucherService(
        IInventoryVoucherRepository inventoryVoucherRepository,
        ISendSmsService sendSmsService)
    {
        _inventoryVoucherRepository = inventoryVoucherRepository;
        _sendSmsService = sendSmsService;
    }

    public IEnumerable<InventoryVoucher> GetInventoryVouchers()
    {
        var inventoryVouchers = _inventoryVoucherRepository.GetInventoryVouchers();
        return inventoryVouchers;
    }

    public IEnumerable<ViewInventoryVoucher> GetViewInventoryVouchers()
    {
        var viewInventoryVouchers = _inventoryVoucherRepository.GetViewInventoryVouchers();
        return viewInventoryVouchers;
    }

    public IEnumerable<InventoryVoucher> SearchInventoryVouchers(string voucherNumber)
    {
        var inventoryVouchers = _inventoryVoucherRepository.SearchInventoryVouchers(voucherNumber);

        //_sendSmsService.Send("xxx", "سرچ شما انجام شد.");

        return inventoryVouchers;
    }
}
