using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Contracts.Services;

public interface ISerialNumberService
{
    IEnumerable<InventoryVoucherSerialNumber> GetInventoryVoucherSerialNumbers(int inventoryVoucherId);
}