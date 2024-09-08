using Microsoft.AspNetCore.Mvc;
using mvc_ska.services;

namespace mvc_ska.Controllers;

[Route("[controller]")]
public class AccountController : Controller
{
    private readonly AccountService _accountService;
    public AccountController(AccountService accountService)
    {
        _accountService = accountService;
    }
    [HttpGet]
    // GET
    public IActionResult Index()
    {
            return View();
    }
}