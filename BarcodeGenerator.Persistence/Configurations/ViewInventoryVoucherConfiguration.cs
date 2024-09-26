using BarcodeGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarcodeGenerator.Persistence.Configurations;

public class ViewInventoryVoucherConfiguration : IEntityTypeConfiguration<ViewInventoryVoucher>
{
    public void Configure(EntityTypeBuilder<ViewInventoryVoucher> builder)
    {
        builder.ToView(nameof(ViewInventoryVoucher))
            .HasKey(v => v.Id);
    }
}
