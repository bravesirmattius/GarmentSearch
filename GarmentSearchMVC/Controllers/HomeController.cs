using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GarmentSearchMVC.Models;
using GarmentSearch.Core.Interfaces;
using GarmentSearch.Core.Models;

namespace GarmentSearchMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGarmentSearchService garmentSearchService;

        public HomeController(ILogger<HomeController> logger, IGarmentSearchService garmentSearchService)
        {
            _logger = logger;
            this.garmentSearchService = garmentSearchService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SearchGarments(string searchCritera)
        {
            var garments  = garmentSearchService.SearchGarment(searchCritera);
            return Json(new
            {
                items = garments.OrderBy(a => a.Colours.Min(c=> c.Pricing))
            });

        }
    }
}
