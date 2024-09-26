using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Contracts.Repositories;

public interface IInventoryVoucherRepository
{
    IEnumerable<InventoryVoucher> GetInventoryVouchers();
    IEnumerable<ViewInventoryVoucher> GetViewInventoryVouchers();
    IEnumerable<InventoryVoucher> SearchInventoryVouchers(string voucherNumber);
}
