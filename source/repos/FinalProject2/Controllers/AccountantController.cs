using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject2.BankServices;

namespace FinalProject2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountantController: ControllerBase
    {
        private static AccountantService _accountantService;
        public AccountantController(AccountantService accountantService)
        {
            _accountantService = accountantService;
        }



        [HttpPost("AccountantInfo")]
        public IActionResult AccountantInfo([FromBody] Accountant accountant)
        {
            if (!_accountantService.AddAccountant(accountant))
            {
                return BadRequest("Accountant already exists");
            }
            return Ok("Accountant added successfully");
        }




        [HttpGet("AccountantJob")]
        public IActionResult AccountantJob([FromBody] User user)
        {
            _accountantService.AccountantCheck(user);
            return Ok("User status changed successfully");
        }

    }
}
