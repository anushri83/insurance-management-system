using Microsoft.AspNetCore.Mvc;

namespace InsuranceAPI.controller
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
