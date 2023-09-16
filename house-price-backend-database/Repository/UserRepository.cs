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

        public async Task<bool> UserLogin(UserLoginDTO userLoginDTO)
        {
            try
            {
                var checkLogin = _context.Users
                    .Where(e => e.EmailId == userLoginDTO.EmailID && e.Password == userLoginDTO.Password)
                    .FirstOrDefaultAsync();

                return true;
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
                    FirstName = userRegistrationDTO.FirstName,
                    LastName = userRegistrationDTO.LastName,
                    EmailId = userRegistrationDTO.EmailId,
                    Address = userRegistrationDTO.Address,
                    ContactNumber = userRegistrationDTO.ContactNumber,

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
