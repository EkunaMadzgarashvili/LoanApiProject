using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject2.BankServices;


namespace FinalProject2.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private static UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Registration")]
        public IActionResult Registration([FromBody] User user)
        {
            if (!_userService.Authorization(user))
            {
                return BadRequest("User already exists");
            }
            return Ok("User added successfully");
        }



        [HttpGet("ChangeLoan")]

        public IActionResult ChangeLoan([FromBody] User user)
        {
            if (!_userService.ChangeLoanInformation(user)) { return BadRequest("User cant change loan"); }
            return Ok("User loan changed successfully");
        }
    }
}
