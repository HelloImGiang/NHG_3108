using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
public class StudentController : Controller 
{
    public IActionResult Index()
    {
            // khơi tao lisr student
            return View();
    }
    

    public IActionResult Create()   
        {
            return View();
        }
    }
}