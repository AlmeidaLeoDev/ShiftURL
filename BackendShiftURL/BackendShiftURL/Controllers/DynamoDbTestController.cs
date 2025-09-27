using Microsoft.AspNetCore.Mvc;

namespace BackendShiftURL.Controllers
{
    public class DynamoDbTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
