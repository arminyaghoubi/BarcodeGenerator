using BarcodeGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarcodeGenerator.Persistence.Configurations;

public class InventoryVoucherConfiguration : IEntityTypeConfiguration<InventoryVoucher>
{
    public void Configure(EntityTypeBuilder<InventoryVoucher> builder)
    {
        builder.ToTable("InventoryVoucher")
            .Property(i => i.PartName).HasMaxLength(256);

        builder.HasIndex(i => new { i.PartName, i.VoucherNumber })
            .IsUnique();

        builder.Property(i => i.PartName).IsRequired();
        builder.Property(i => i.VoucherNumber).IsRequired();
        builder.Property(i => i.CounterpartDLCode).IsRequired();
    }
}
