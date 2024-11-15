﻿using BarcodeGenerator.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeGenerator.MVC.Controllers;

public class InventoryVoucherController : Controller
{
    private readonly IInventoryVoucherService _inventoryVoucherService;

    public InventoryVoucherController(IInventoryVoucherService inventoryVoucherService)
    {
        _inventoryVoucherService = inventoryVoucherService;
    }

    public IActionResult Index()
    {
        // Load Data InventoryVoucher
        var inventoryVouchers = _inventoryVoucherService.GetInventoryVouchers();

        return View(inventoryVouchers);
    }

    public IActionResult GetInventoryVoucherFromView()
    {
        var viewInventoryVouchers = _inventoryVoucherService.GetViewInventoryVouchers();

        return View(viewInventoryVouchers);
    }

    public IActionResult SearchInventoryVouchers(string voucherNumber = null)
    {
        ViewData["SearchVoucherNumber"] = voucherNumber;

        var inventoryVouchers = _inventoryVoucherService.SearchInventoryVouchers(voucherNumber);

        return View("Index", inventoryVouchers);
    }
}
