using house_price_backend_dto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.IRepository
{
    public interface IUserRepository
    {
        Task<bool> UserRegistarion(UserRegistrationDTO userRegistrationDTO);
        Task<bool> UserLogin(UserLoginDTO userLoginDTO);
    }
}
