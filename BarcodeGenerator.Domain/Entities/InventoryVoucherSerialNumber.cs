namespace BarcodeGenerator.Domain.Entities;

public class InventoryVoucherSerialNumber
{
	public int Id { get; set; }
	public string SerialNumber { get; set; }
	public int PrintCounter { get; set; }

	public int InventoryVoucherId { get; set; }
	public InventoryVoucher InventoryVoucher { get; set; }
}
