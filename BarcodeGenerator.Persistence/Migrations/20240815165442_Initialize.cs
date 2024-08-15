using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeGenerator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VoucherNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CounterpartDLCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVoucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryVoucherSerialNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PrintCounter = table.Column<int>(type: "int", nullable: false),
                    InventoryVoucherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVoucherSerialNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryVoucherSerialNumber_InventoryVoucher_InventoryVoucherId",
                        column: x => x.InventoryVoucherId,
                        principalTable: "InventoryVoucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_VoucherNumber",
                table: "InventoryVoucher",
                column: "VoucherNumber",
                unique: true,
                filter: "[VoucherNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucherSerialNumber_InventoryVoucherId",
                table: "InventoryVoucherSerialNumber",
                column: "InventoryVoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucherSerialNumber_SerialNumber",
                table: "InventoryVoucherSerialNumber",
                column: "SerialNumber",
                unique: true,
                filter: "[SerialNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryVoucherSerialNumber");

            migrationBuilder.DropTable(
                name: "InventoryVoucher");
        }
    }
}
