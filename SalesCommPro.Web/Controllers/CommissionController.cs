using Microsoft.AspNetCore.Mvc;
using SalesCommPro.Web.Models;
using SalesCommPro.Application.DTOs;
using SalesCommPro.Infrastructure.Services;

namespace SalesCommPro.Web.Controllers
{
    public class CommissionController : Controller
    {
        private readonly CommissionService _service;

        public CommissionController(CommissionService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new CommissionModel();

            if (TempData["Sales"] != null)
                model.Sales = decimal.Parse(TempData["Sales"].ToString());

            if (TempData["Discount"] != null)
                model.Discount = decimal.Parse(TempData["Discount"].ToString());

            if (TempData["Country"] != null)
                model.Country = TempData["Country"].ToString();

            if (TempData["Result"] != null)
            {
                model.Result = decimal.Parse(TempData["Result"].ToString());
                model.HasResult = true;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CommissionModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dto = new CommissionDTO
            {
                Sales = model.Sales.Value,
                Discount = model.Discount.Value,
                Country = model.Country
            };

            var result = _service.Calculate(dto);

            TempData["Sales"] = model.Sales.ToString();
            TempData["Discount"] = model.Discount.ToString();
            TempData["Country"] = model.Country;
            TempData["Result"] = result.ToString();

            return RedirectToAction("Index");
        }
    }
}