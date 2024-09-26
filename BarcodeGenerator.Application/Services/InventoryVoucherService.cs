using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Application.Contracts.Services;
using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Services;

public class InventoryVoucherService : IInventoryVoucherService
{
    private readonly IInventoryVoucherRepository _inventoryVoucherRepository;

    public InventoryVoucherService(IInventoryVoucherRepository inventoryVoucherRepository)
    {
        _inventoryVoucherRepository = inventoryVoucherRepository;
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
}
