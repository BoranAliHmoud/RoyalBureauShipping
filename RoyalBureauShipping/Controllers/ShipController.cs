using Certificate.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration;
using RoyalBureauShipping.Models;
using RoyalBureauShipping.ViewModels;
using System.Drawing;
using QRCoder;

using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Net.WebRequestMethods;

namespace RoyalBureauShipping.Controllers
{
    public class ShipController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment _env;

        private readonly IWebHostEnvironment _environment;
        public ShipController(ApplicationDbContext context, IWebHostEnvironment environment, IHostEnvironment env)
        {
            _context = context;
            _env = env;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var shipsList = _context.Ships.ToList();
            return View(shipsList);
        }
        public IActionResult Create()
        {
            List<CargoShip> CargoShip = _context.CargoShips.ToList();
            ViewBag.CargoShip = CargoShip;
            return View();
        }
        [HttpPost]
        public IActionResult Create(ShipViewModel data)
        {
            if (data == null)
            { return View();
            }

            ShipModel model = new ShipModel()
            {
                VesselName = data.VesselName,
                ShipAddress = data.ShipAddress,
                IMO_NO = data.IMO_NO,
                Class_Id = data.Class_Id,
                GRT = data.GRT,
                Port_Of_Register = data.Port_Of_Register,
                Depth = data.Depth,
                Leangh = data.Leangh,
                Breadth = data.Breadth,
                Propulsion = data.Propulsion,
                 CargoShipId=data.CargoShipId,
                EffectiveDate = data.EffectiveDate,
                RevisionDate = data.RevisionDate,
                DateofIssue = data.DateofIssue,
                ValidUntil = data.ValidUntil, 
                Year = data.Year,
                ClassificationCharacters = data.ClassificationCharacters,
                PortSurvey = data.PortSurvey,
                 GrossTonnage = data.GrossTonnage,
                 DeadweightShip = data.DeadweightShip, 
                DateBuildingContract = data.DateBuildingContract,
                CasualHistory = data.CasualHistory,
                DateDelivery = data.DateDelivery,
                ExemptionCertificate = data.ExemptionCertificate,
                CertificateValid = data.CertificateValid,
                CompletionDateSurvey = data.CompletionDateSurvey,
                CreatedDate = DateTime.Now,
                FirstPostOutInspection = data.FirstPostOutInspection,
                SecondPostOutInspection = data.SecondPostOutInspection,
                IssuedAt = data.IssuedAt 
      
            }; 
            _context.Ships.Add(model);
            _context.SaveChanges();
            var qrdata = CreateQRCode(model.Id.ToString());

            return RedirectToAction("Edit",new {Id=model.Id});
        }
        public IActionResult Edit(int Id)
        {
            List<CargoShip> CargoShip = _context.CargoShips.ToList();
            var data = _context.Ships.FirstOrDefault(x=>x.Id==Id);
            if (data == null)
            {
                return View("Create");
            }
            ShipViewModel model = new ShipViewModel()
            {
                VesselName = data.VesselName,
                ShipAddress = data.ShipAddress,
                IMO_NO = data.IMO_NO,
                Class_Id = data.Class_Id,
                GRT = data.GRT,
                Port_Of_Register = data.Port_Of_Register,
                Depth = data.Depth,
                Leangh = data.Leangh,
                Breadth = data.Breadth,
                Propulsion = data.Propulsion,
                CargoShipId = data.CargoShipId,
                EffectiveDate = data.EffectiveDate,
                RevisionDate = data.RevisionDate,
                DateofIssue = data.DateofIssue,
                ValidUntil = data.ValidUntil,
                Year = data.Year,
                ClassificationCharacters = data.ClassificationCharacters,
                PortSurvey = data.PortSurvey,
                GrossTonnage = data.GrossTonnage,
                DeadweightShip = data.DeadweightShip,
                DateBuildingContract = data.DateBuildingContract,
                CasualHistory = data.CasualHistory,
                DateDelivery = data.DateDelivery,
                ExemptionCertificate = data.ExemptionCertificate,
                CertificateValid = data.CertificateValid,
                CompletionDateSurvey = data.CompletionDateSurvey,
                CreatedDate = DateTime.Now,
                FirstPostOutInspection = data.FirstPostOutInspection,
                SecondPostOutInspection = data.SecondPostOutInspection,
                IssuedAt = data.IssuedAt

            };
            ViewBag.CargoShip = CargoShip;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ShipViewModel data)
        {
            ShipModel model = new ShipModel()
            {
                VesselName = data.VesselName,
                ShipAddress = data.ShipAddress,
                IMO_NO = data.IMO_NO,
                Class_Id = data.Class_Id,
                GRT = data.GRT,
                Port_Of_Register = data.Port_Of_Register,
                Depth = data.Depth,
                Leangh = data.Leangh,
                Breadth = data.Breadth,
                Propulsion = data.Propulsion,
                CargoShipId = data.CargoShipId,
                EffectiveDate = data.EffectiveDate,
                RevisionDate = data.RevisionDate,
                DateofIssue = data.DateofIssue,
                ValidUntil = data.ValidUntil,
                Year = data.Year,
                ClassificationCharacters = data.ClassificationCharacters,
                PortSurvey = data.PortSurvey,
                GrossTonnage = data.GrossTonnage,
                DeadweightShip = data.DeadweightShip,
                DateBuildingContract = data.DateBuildingContract,
                CasualHistory = data.CasualHistory,
                DateDelivery = data.DateDelivery,
                ExemptionCertificate = data.ExemptionCertificate,
                CertificateValid = data.CertificateValid,
                CompletionDateSurvey = data.CompletionDateSurvey,
                CreatedDate = DateTime.Now,
                FirstPostOutInspection = data.FirstPostOutInspection,
                SecondPostOutInspection = data.SecondPostOutInspection,
                IssuedAt = data.IssuedAt
            };
            _context.Ships.Add(model);
            _context.SaveChanges();
            var qrdata = CreateQRCode(model.Id.ToString());
            return View();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var ShipSafety = await _context.Ships.FindAsync(id);

            if (ShipSafety == null)
                return NotFound();

            _context.Ships.Remove(ShipSafety);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult ExportPDF(long id)
        {
            
            var Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer

            // To include elements that are usually removed to save ink during printing we choose screen
            Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
            var Url = $"https://{HttpContext.Request.Host}/Ship/SAFETYCONSTRUCTIONCERTIFICATE?id={id}";
            var pdf = Renderer.RenderUrlAsPdf( Url);
            pdf.SaveAs("Reports/url_saved.pdf");
            return File(System.IO.File.OpenRead("Reports/url_saved.pdf"), "application/force-download", Path.GetFileName("Reports/url_saved.pdf"));
        }


        public bool CreateQRCode(string id)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            var Url = $"https://{HttpContext.Request.Host}/Ship/SAFETYCONSTRUCTIONCERTIFICATE?id={id}";

            QRCodeData qrCodeData = qrGenerator.CreateQrCode( Url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            var bitmapBytes = BitmapToBytes(qrCodeImage); //Convert bitmap into a byte array

            FileHelper helper = new FileHelper(_env);

            var path = System.String.Concat("wwwroot/GeneratedQRCode/shipsafety/");

            bool massege = helper.PhotoAdd(path, bitmapBytes, id, "jpeg");
            return massege;

                    }
        private Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        
        public async Task<IActionResult> SAFETYCONSTRUCTIONCERTIFICATE(int id)
        {
            var ShipSafety = await _context.Ships.FindAsync(id);
            List<CargoShip> CargoShip = _context.CargoShips.ToList();
            ViewBag.CargoShip = CargoShip;

            return View(ShipSafety);
        }
    }
}
