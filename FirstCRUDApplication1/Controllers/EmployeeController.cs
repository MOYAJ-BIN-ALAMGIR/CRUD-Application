using FirstCRUDApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCRUDApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }
        //HTTP POST VERSION 
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repository.Create(employee);
            return View("Thanks", employee);
        }
    }
}
