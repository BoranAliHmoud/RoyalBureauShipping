using Microsoft.AspNetCore.Mvc;
using RoyalBureauShipping.Models;
using RoyalBureauShipping.Services;
using System.Diagnostics;

namespace RoyalBureauShipping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly PdfGenerationService _pdfService;
		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
		public IActionResult ConvertToPdf()
		{
			string url = "https://www.example.com"; // Replace with the URL of the webpage you want to convert
			string outputPath = "path/to/output.pdf"; // Replace with the desired output path

			_pdfService.ConvertWebPageToPdf(url, outputPath);

			return RedirectToAction("Index");
		}
	}
}