using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Contracts.Services;

public interface IInventoryVoucherService
{
    IEnumerable<InventoryVoucher> GetInventoryVouchers();
    IEnumerable<ViewInventoryVoucher> GetViewInventoryVouchers();
}
