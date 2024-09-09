using Microsoft.AspNetCore.Mvc;
using mvc_ska.services;

namespace mvc_ska.Controllers.api.v1;

[Route("api")]
public class RecordController : Controller
{
    private readonly AccountService _accountService;
    public RecordController(AccountService accountService)
    {
        _accountService = accountService;
    }
    
    [HttpGet("records")]
    public IActionResult Records()
    {
        return Ok(_accountService.accounts);
    }
}