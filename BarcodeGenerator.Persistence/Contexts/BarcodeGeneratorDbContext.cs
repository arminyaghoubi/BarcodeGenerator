using BarcodeGenerator.Domain.Entities;
using BarcodeGenerator.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BarcodeGenerator.Persistence.Contexts;

public class BarcodeGeneratorDbContext : DbContext
{
    public BarcodeGeneratorDbContext(DbContextOptions options) : base(options) { }

	public DbSet<InventoryVoucher> InventoryVouchers { get; set; }
	public DbSet<InventoryVoucherSerialNumber> SerialNumbers { get; set; }
    public DbSet<ViewInventoryVoucher> ViewInventoryVouchers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BarcodeGeneratorDbContext).Assembly);

        //modelBuilder.ApplyConfiguration(new InventoryVoucherConfiguration());
        //modelBuilder.ApplyConfiguration(new InventoryVoucherSerialNumberConfiguration());
        //modelBuilder.ApplyConfiguration(new ViewInventoryVoucherConfiguration());

        base.OnModelCreating(modelBuilder);
	}
}
