﻿using BarcodeGenerator.Domain.Entities;

namespace BarcodeGenerator.Application.Contracts.Repositories;

public interface IInventoryVoucherRepository
{
    IEnumerable<InventoryVoucher> GetInventoryVouchers();
}
