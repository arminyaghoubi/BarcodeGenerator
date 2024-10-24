using BarcodeGenerator.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeGenerator.MVC.Controllers
{
    public class SerialNumberController : Controller
    {
        private readonly ISerialNumberService _serialNumberService;

        public SerialNumberController(ISerialNumberService serialNumberService)
        {
            _serialNumberService = serialNumberService;
        }

        public IActionResult Index(int id)
        {
            ViewData["Id"] = id;

            var serialNumbers = _serialNumberService.GetInventoryVoucherSerialNumbers(id);

            return View(serialNumbers);
        }
    }
}
