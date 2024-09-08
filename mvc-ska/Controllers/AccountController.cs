using Microsoft.AspNetCore.Mvc;

namespace mvc_ska.Controllers;

[Route("[controller]")]
public class AccountController : Controller
{
    [HttpGet]
    // GET
    public IActionResult Index()
    {
        return View();
    }
}