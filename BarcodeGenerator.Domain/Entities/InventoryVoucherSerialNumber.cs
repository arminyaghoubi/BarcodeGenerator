namespace BarcodeGenerator.Domain.Entities;

public class InventoryVoucherSerialNumber: EntityBase
{
    public string SerialNumber { get; set; }
    public int PrintCounter { get; set; }

    public int InventoryVoucherId { get; set; }
    public InventoryVoucher InventoryVoucher { get; set; }
}
