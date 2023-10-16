using house_price_backend_api.Controllers;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_unit_testing.Testing
{
    [TestFixture]
    public class UserControllerTesting
    {
        private Mock<IUserService> _userServiceMock;
        private UserController _userController;

        [SetUp]
        public void Setup()
        {
            _userServiceMock = new Mock<IUserService>();
            _userController = new UserController(_userServiceMock.Object);
        }
        [Test]
        public void UserRegistration()
        {
            var NewUser = new UserRegistrationDTO
            {
               Name="Dasun",
               Email="icbt@gmail.com",
               Password="12345",
               Contact="0716372333",
               UserType="customer"

            };

            _userServiceMock.Setup(x => x.UserRegistarion(NewUser)).ReturnsAsync(true);
            var resultSuccess = _userController.User(NewUser);

            Assert.IsInstanceOf<OkObjectResult>(resultSuccess.Result);
            var okResultS = (OkObjectResult)resultSuccess.Result;
            Assert.AreEqual(200, okResultS.StatusCode);
        }
        [Test]
        public void Login()
        {
            var UserLogin = new UserLoginDTO
            {
                EmailID = "icbt@gmail.com",
                Password = "12345",

            };

            _userServiceMock.Setup(x => x.UserLogin(UserLogin)).ReturnsAsync(true);
            var resultSuccess = _userController.UserLogin(UserLogin);

            Assert.IsInstanceOf<OkObjectResult>(resultSuccess.Result);
            var okResultS = (OkObjectResult)resultSuccess.Result;
            Assert.AreEqual(200, okResultS.StatusCode);
        }
    }
}
