using Microsoft.AspNetCore.Mvc;

namespace MVC0.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
