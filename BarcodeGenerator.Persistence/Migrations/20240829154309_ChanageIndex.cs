using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeGenerator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChanageIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_PartName_VoucherNumber",
                table: "InventoryVoucher",
                columns: new[] { "PartName", "VoucherNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucher_PartName_VoucherNumber",
                table: "InventoryVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher",
                column: "VoucherNumber",
                unique: true);
        }
    }
}
