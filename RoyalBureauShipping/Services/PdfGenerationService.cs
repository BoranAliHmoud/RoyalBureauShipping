//using System.IO;
//using iText.IO.Image;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using PdfDocument = iText.Kernel.Pdf.PdfDocument;

//namespace RoyalBureauShipping.Services
//{
//	public class PdfGenerationService
//	{
//		public void ConvertWebPageToPdf(string url, string outputPath)
//		{
//			// Start a headless Chrome browser
//			using (var driver = new ChromeDriver())
//			{
//				// Navigate to the webpage
//				driver.Navigate().GoToUrl(url);

//				// Take a screenshot of the webpage
//				var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

//				// Save the screenshot as an image
//				var tempImagePath = Path.Combine(Path.GetTempPath(), "webpage_screenshot.png");
//				screenshot.SaveAsFile(tempImagePath, ScreenshotImageFormat.Png);

//				// Convert the image to a PDF
//				using (var pdfDocument = new PdfDocument(new PdfWriter(outputPath)))
//				using (var document = new Document(pdfDocument))
//				{
//					var image = new Image(ImageDataFactory.Create(tempImagePath));
//					document.Add(image);
//				}

//				// Delete the temporary image file
//				File.Delete(tempImagePath);
//			}
//		}
//	}
//}
