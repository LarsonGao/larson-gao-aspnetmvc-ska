using Microsoft.AspNetCore.Mvc;
using mvc_ska.services;

namespace mvc_ska.Controllers.api.v1;

[Route("api/v1/[controller]")]
public class AccountController : Controller
{
    private readonly AccountService _accountService;
    public AccountController(AccountService accountService)
    {
        _accountService = accountService;
    }
    
    [HttpGet("list")]
    public IActionResult List()
    {
        return Ok(_accountService.accounts);
    }
}