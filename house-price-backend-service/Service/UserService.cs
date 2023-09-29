using house_price_backend_database.IRepository;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<object> UserLogin(UserLoginDTO userLoginDTO)
        {
            var UserLog = await _userRepository.UserLogin(userLoginDTO);
            return UserLog;
        }

        public async Task<bool> UserRegistarion(UserRegistrationDTO userRegistrationDTO)
        {
            var Users= await _userRepository.UserRegistarion(userRegistrationDTO);
            return true;
        }
    }
}
