using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Application.Contracts.Services;
using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Services;

public class SerialNumberService : ISerialNumberService
{
    private readonly IInventoryVoucherRepository _voucherRepository;
    private readonly IInventoryVoucherSerialNumberRepository _serialNumberRepository;

    public SerialNumberService(IInventoryVoucherRepository voucherRepository,
        IInventoryVoucherSerialNumberRepository serialNumberRepository)
    {
        _voucherRepository = voucherRepository;
        _serialNumberRepository = serialNumberRepository;
    }

    public IEnumerable<InventoryVoucherSerialNumber> GetInventoryVoucherSerialNumbers(int inventoryVoucherId)
    {
        var serialNumbers = _serialNumberRepository.GetInventoryVoucherSerialNumbersById(inventoryVoucherId).ToList();

        if (serialNumbers.Any())
            return serialNumbers;

        var inventoryVoucher = _voucherRepository.GetInventoryVoucherById(inventoryVoucherId);
        if (inventoryVoucher is null)
            throw new Exception("Inventory Voucher Not Found");

        var serialNumberCounter = _serialNumberRepository.GetInventoryVoucherSerialNumberCount();

        // Generate Barcode
        for (int i = 0; i < inventoryVoucher.Quantity; i++)
        {
            serialNumberCounter++;

            string newSerialNumber = $"S{serialNumberCounter.ToString().PadLeft(5, '0')}";

            serialNumbers.Add(new InventoryVoucherSerialNumber
            {
                InventoryVoucherId = inventoryVoucherId,
                PrintCounter = 0,
                SerialNumber = newSerialNumber
            });
        }

        _serialNumberRepository.CreateInventoryVoucherSerialNumbers(serialNumbers);

        return serialNumbers;
    }
}
