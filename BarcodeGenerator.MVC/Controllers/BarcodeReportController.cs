using BarcodeGenerator.Application.Contracts.Services;
using BarcodeGenerator.MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace BarcodeGenerator.MVC.Controllers;

public class BarcodeReportController : Controller
{
    private readonly ISerialNumberService _serialNumberService;

    public BarcodeReportController(ISerialNumberService serialNumberService)
    {
        _serialNumberService = serialNumberService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetReport(int id)
    {
        StiReport report = new();

        string reportPath = StiNetCoreHelper.MapPath(this, "Reports/Report.mrt");

        report.Load(reportPath);

        var serialNumbers = _serialNumberService.GetInventoryVoucherSerialNumbers(id)
            .Select(s => new SerialNumberViewModel
            {
                SerialNumber = s.SerialNumber
            });

        report.RegData("BarcodeDataSource", serialNumbers);

        return StiNetCoreViewer.GetReportResult(this, report);
    }

    public IActionResult ViewerEvent()
    {
        return StiNetCoreViewer.ViewerEventResult(this);
    }
}
