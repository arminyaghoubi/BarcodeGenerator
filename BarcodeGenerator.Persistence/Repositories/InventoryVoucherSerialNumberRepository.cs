using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Domain.Entities;
using BarcodeGenerator.Persistence.Contexts;

namespace BarcodeGenerator.Persistence.Repositories;

public class InventoryVoucherSerialNumberRepository : IInventoryVoucherSerialNumberRepository
{
    private readonly BarcodeGeneratorDbContext _context;

    public InventoryVoucherSerialNumberRepository(BarcodeGeneratorDbContext context)
    {
        _context = context;
    }

    public IEnumerable<InventoryVoucherSerialNumber> GetInventoryVoucherSerialNumbersById(int inventoryVoucherId)
    {
        return _context.SerialNumbers
            .Where(s => s.InventoryVoucherId == inventoryVoucherId)
            .ToList();
    }

    public void CreateInventoryVoucherSerialNumbers(IEnumerable<InventoryVoucherSerialNumber> serialNumbers)
    {
        _context.SerialNumbers.AddRange(serialNumbers);

        _context.SaveChanges();
    }

    public int GetInventoryVoucherSerialNumberCount()
    {
        return _context.SerialNumbers.Count();
    }
}
