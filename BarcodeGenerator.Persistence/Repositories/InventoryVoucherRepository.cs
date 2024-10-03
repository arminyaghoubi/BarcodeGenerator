using BarcodeGenerator.Application.Contracts.Repositories;
using BarcodeGenerator.Domain.Entities;
using BarcodeGenerator.Persistence.Contexts;
using Microsoft.Data.SqlClient;
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
            .FromSqlRaw("SearchInventoryVoucher @p0", voucherNumber)
            .AsNoTracking()
            .ToList();
    }

    public InventoryVoucher GetInventoryVoucherById(int inventoryVoucherId)
    {
        return _context.InventoryVouchers.Find(inventoryVoucherId);
        //return _context.InventoryVouchers.FirstOrDefault(i => i.Id == inventoryVoucherId);
    }
}

//public class InventoryVoucherRepositoryMongoDB : IInventoryVoucherRepository
//{
//    public IEnumerable<InventoryVoucher> GetInventoryVouchers()
//    {
//        throw new NotImplementedException();
//    }

//    public IEnumerable<ViewInventoryVoucher> GetViewInventoryVouchers()
//    {
//        throw new NotImplementedException();
//    }

//    public IEnumerable<InventoryVoucher> SearchInventoryVouchers(string voucherNumber)
//    {
//        throw new NotImplementedException();
//    }
//}