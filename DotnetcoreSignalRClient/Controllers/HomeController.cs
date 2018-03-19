using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreSignalRClient
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}