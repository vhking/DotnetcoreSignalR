using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreSignalRClient
{
    public class PublisherController : Controller
    {
        public IActionResult Index() => View();
    }
}