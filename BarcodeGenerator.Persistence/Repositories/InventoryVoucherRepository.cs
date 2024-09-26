using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Domain.Entities;
using BarcodeGenerator.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BarcodeGenerator.Persistence.Repositories;

public class InventoryVoucherRepository : IInventoryVoucherRepository
{
    private readonly BarcodeGeneratorDbContext _context;

    public InventoryVoucherRepository(BarcodeGeneratorDbContext context)
    {
        _context = context;
    }

    public IEnumerable<InventoryVoucher> GetInventoryVouchers()
    {
        return _context.InventoryVouchers
            .AsNoTracking()
            .ToList();
    }

    public IEnumerable<ViewInventoryVoucher> GetViewInventoryVouchers()
    {
        return _context.ViewInventoryVouchers
            .AsNoTracking()
            .ToList();
    }

    public IEnumerable<InventoryVoucher> SearchInventoryVouchers(string voucherNumber)
    {
        return _context.InventoryVouchers
            .FromSqlRaw("EXECUTE dbo.SearchInventoryVoucher @p0", voucherNumber)
            .ToList();
    }
}
