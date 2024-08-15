using BarcodeGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarcodeGenerator.Persistence.Configurations;

public class InventoryVoucherSerialNumberConfiguration : IEntityTypeConfiguration<InventoryVoucherSerialNumber>
{
	public void Configure(EntityTypeBuilder<InventoryVoucherSerialNumber> builder)
	{
		builder.ToTable("InventoryVoucherSerialNumber");

		builder.HasIndex(i => i.SerialNumber)
			.IsUnique();

		builder.Property(i => i.SerialNumber).IsRequired();
	}
}