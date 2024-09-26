namespace BarcodeGenerator.Domain.Entities;

public class ViewInventoryVoucher : EntityBase
{
    public string PartName { get; set; }
    public string VoucherNumber { get; set; }
    public int Quantity { get; set; }
}