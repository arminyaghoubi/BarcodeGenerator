using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Contracts.Repositories;

public interface IInventoryVoucherSerialNumberRepository
{
    IEnumerable<InventoryVoucherSerialNumber> GetInventoryVoucherSerialNumbersById(int inventoryVoucherId);
    void CreateInventoryVoucherSerialNumbers(IEnumerable<InventoryVoucherSerialNumber> serialNumbers);
    int GetInventoryVoucherSerialNumberCount();
}