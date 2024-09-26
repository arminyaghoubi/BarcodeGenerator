using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeGenerator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateViewInventoryVoucher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE	VIEW	ViewInventoryVoucher
AS
	Select	Id,
            PartName,
            VoucherNumber,
            Quantity
	From	dbo.InventoryVoucher
	WHERE	Quantity	>	2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop  VIEW    ViewInventoryVoucher");
        }
    }
}
