using Microsoft.AspNetCore.Mvc;

namespace DemoGitHub.Controllers
{
    // Josh Hampton - Very simple example controller that takes a name as a parameter,
    // and passes it to the view using ViewBag.
    public class NameController : Controller
    {
        public IActionResult Welcome(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
