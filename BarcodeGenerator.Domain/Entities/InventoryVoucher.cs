namespace BarcodeGenerator.Domain.Entities;

public class InventoryVoucher
{
	public int Id { get; set; }
	public string PartName { get; set; }
	public string VoucherNumber { get; set; }
	public int Quantity { get; set; }
	public string CounterpartDLCode { get; set; }

	public ICollection<InventoryVoucherSerialNumber> SerialNumbers { get; set; }
}
