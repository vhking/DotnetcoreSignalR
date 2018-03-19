using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreSignalRClient
{
    public class ReportsController : Controller
    {
        public IActionResult Index() => View();
    }
}