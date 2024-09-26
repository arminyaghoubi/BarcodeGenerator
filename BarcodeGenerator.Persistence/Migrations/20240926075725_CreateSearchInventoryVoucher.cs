using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarcodeGenerator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateSearchInventoryVoucher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Armin Yaghoubi
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE SearchInventoryVoucher 
	-- Add the parameters for the stored procedure here
	@VoucherNumber	NVARCHAR(450)	=	NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select	Id,
            PartName,
            VoucherNumber,
            Quantity,
            CounterpartDLCode
	From	dbo.InventoryVoucher
	WHERE	VoucherNumber	LIKE	'%'+@VoucherNumber+'%'
	OR		VoucherNumber	=		ISNULL(@VoucherNumber,VoucherNumber)

END
GO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP  PROCEDURE   SearchInventoryVoucher");
        }
    }
}
