using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace lab7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View("~/Views/Home/DownloadFile.cshtml");
        }

        [HttpPost]
        public IActionResult DownloadFile(string name, string surname, string fileName)
        {
            string content = $"Name: {name}\nSurname: {surname}";
            byte[] fileBytes = Encoding.UTF8.GetBytes(content);
            string fileDownloadName = $"{fileName}.txt";

            return File(fileBytes, "text/plain", fileDownloadName);
        }
    }
}
