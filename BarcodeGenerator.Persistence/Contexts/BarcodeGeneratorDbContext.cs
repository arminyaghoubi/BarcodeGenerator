using BarcodeGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarcodeGenerator.Persistence.Contexts;

public class BarcodeGeneratorDbContext : DbContext
{
    public BarcodeGeneratorDbContext(DbContextOptions options) : base(options) { }

	public DbSet<InventoryVoucher> InventoryVouchers { get; set; }
	public DbSet<InventoryVoucherSerialNumber> SerialNumbers { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(BarcodeGeneratorDbContext).Assembly);

		base.OnModelCreating(modelBuilder);
	}
}
