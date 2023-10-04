using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace house_price_backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("UserRegistartion")]
        public async Task<IActionResult> User(UserRegistrationDTO userRegistrationDTO)
        {
            var result =await _userService.UserRegistarion(userRegistrationDTO);
            return Ok(result);
        }
        [HttpPost("UserLoginDetails")]
        public async Task<IActionResult>UserLogin(UserLoginDTO userLoginDTO)
        {
            var result=await _userService.UserLogin(userLoginDTO);
            if (result != null)
            {
                return Ok(result);
            }
            else

                return NotFound();
        }
   

    }
}
