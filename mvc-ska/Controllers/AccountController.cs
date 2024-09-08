using Microsoft.AspNetCore.Mvc;
using mvc_ska.Models;
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
    public IActionResult Index()
    {
            return View();
    }

    public IActionResult Create(Account account)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", account);
        }

        account.id = _accountService.nextId++;
        _accountService.accounts.Add(account);
        return View("Index");
    }
    
}