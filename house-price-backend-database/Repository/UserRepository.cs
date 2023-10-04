using house_price_backend_database.IRepository;
using house_price_backend_database.Model;
using house_price_backend_dto.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HouseContext _context;

        public UserRepository(HouseContext context)
        {
            _context = context;
        }

        public async Task<object> UserLogin(UserLoginDTO userLoginDTO)
        {
            try
            {
                var checkLogin = await _context.Users
                    .Where(e => e.Email == userLoginDTO.EmailID && e.Password == userLoginDTO.Password)
                    .FirstOrDefaultAsync();

                return checkLogin;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UserRegistarion(UserRegistrationDTO userRegistrationDTO)
        {
            try
            {
                var users = new User()
                {
                    Name = userRegistrationDTO.Name,
                    Email = userRegistrationDTO.Email,
                    Password = userRegistrationDTO.Password,
                    Contact = userRegistrationDTO.Contact,
                    UserType = userRegistrationDTO.UserType,

                };
                _context.Users.Add(users);
                await _context.SaveChangesAsync();

                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
