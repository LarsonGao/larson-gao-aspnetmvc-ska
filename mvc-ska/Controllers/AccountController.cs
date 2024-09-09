using Microsoft.AspNetCore.Mvc;
using mvc_ska.Models;
using mvc_ska.Models.ViewModels;
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
        AccountView model = new AccountView()
        {
            Account = new Account(),
            Accounts = _accountService.accounts
        };
        return View(model);
    }
    
    [HttpPost]
    public IActionResult CreatePartial(Account account)
    {
        AccountView model = new AccountView()
        {
            Account = account, 
            Accounts = _accountService.accounts
        };
        if (!ModelState.IsValid)
        {
            return View( "Index", model);
        }

        
        account.Id = _accountService.nextId++;
        _accountService.accounts.Add(account);
        return View("Index", model);
    }
}