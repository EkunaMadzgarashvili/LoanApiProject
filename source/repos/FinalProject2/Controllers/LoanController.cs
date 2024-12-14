using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject2.BankServices;

[ApiController]
[Route("[controller]")]

public class LoansController : ControllerBase
{
    private static LoanService _loanService;

    public LoansController(LoanService loanService)
    {
        _loanService = loanService;
    }

    [HttpPost("LoanProperties")]

    public IActionResult EnterLoanProperties([FromBody] Loan loan)
    {
        _loanService.GetLoanProperties(loan);
        return Ok("Loan properties changed successfully");
    }

    [HttpPost("GetInformation")]
    public IActionResult GetInformation([FromBody] User user)
    {
        if (!_loanService.GetInfomation(user))
        {
            return BadRequest("User does not exists");
        }
        return Ok("User information shows up successfully");
    }

    [HttpGet("GetLoan")]
    public IActionResult GetLoan([FromBody] User user)
    {
        if (!_loanService.GetLoan(user))
        {
            return BadRequest("Users cant get loan");
        }
        return Ok("User get loan successfully");
    }

}


