using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeGenerator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRequiredFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucherSerialNumber_SerialNumber",
                table: "InventoryVoucherSerialNumber");

            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "InventoryVoucherSerialNumber",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VoucherNumber",
                table: "InventoryVoucher",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartName",
                table: "InventoryVoucher",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CounterpartDLCode",
                table: "InventoryVoucher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucherSerialNumber_SerialNumber",
                table: "InventoryVoucherSerialNumber",
                column: "SerialNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher",
                column: "VoucherNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucherSerialNumber_SerialNumber",
                table: "InventoryVoucherSerialNumber");

            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "InventoryVoucherSerialNumber",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "VoucherNumber",
                table: "InventoryVoucher",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PartName",
                table: "InventoryVoucher",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "CounterpartDLCode",
                table: "InventoryVoucher",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucherSerialNumber_SerialNumber",
                table: "InventoryVoucherSerialNumber",
                column: "SerialNumber",
                unique: true,
                filter: "[SerialNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher",
                column: "VoucherNumber",
                unique: true,
                filter: "[VoucherNumber] IS NOT NULL");
        }
    }
}
