using house_price_backend_api.Controllers;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace house_price_unit_testing.Testing
{
    [TestFixture]
    public class HouseControllerTest
    {
        private Mock<IHouseDetailsService> _houseDetailsServiceMock;
        private HouseController _houseController;

        [SetUp]
        public void Setup()
        {
            _houseDetailsServiceMock = new Mock<IHouseDetailsService>();
            _houseController = new HouseController(_houseDetailsServiceMock.Object);
        }
        [Test]
        public void EnterhouseDetails()
        {
            var newhouse = new HouseDetailsDTO
            {
                Location="Piliyandala",
                NoOfBedRooms=2,
                NoOfBathRooms=3,
                LivingArea=3000,
                LandArea=9,
                floors=2,
                School=1,
                ShappingMall=1,
                Transport=1,
                Date = DateTime.Parse("2023-06-28T05:50:59.509Z".ToString()),
                CurrencyRate=330,
                Price=40000000,
                Link="www.houce.lk"

            };

            _houseDetailsServiceMock.Setup(x => x.EnterHouseData(newhouse)).ReturnsAsync(true);
            var resultSuccess = _houseController.EnterDetails(newhouse);

            Assert.IsInstanceOf<OkObjectResult>(resultSuccess.Result);
            var okResultS = (OkObjectResult)resultSuccess.Result;
            Assert.AreEqual(200, okResultS.StatusCode);
        }
        [Test]
        public void GetHouseDetails()
        {
            var GetHouses = new List<HouseDetailsSetDTO>
            {
               new HouseDetailsSetDTO
               {
                Id = 1,
                Location="Piliyandala",
                NoOfBedRooms=2,
                NoOfBathRooms=3,
                LivingArea=3000,
                LandArea=9,
                floors=2,
                School=1,
                ShappingMall=1,
                Transport=1,
                Date = DateTime.Parse("2023-06-28T05:50:59.509Z".ToString()),
                CurrencyRate=330,
                Price=40000000,
                Link="www.houce.lk"
               },
               new HouseDetailsSetDTO
               {
                Id = 2,
                Location="Maharagama",
                NoOfBedRooms=2,
                NoOfBathRooms=3,
                LivingArea=3000,
                LandArea=9,
                floors=2,
                School=1,
                ShappingMall=1,
                Transport=1,
                Date = DateTime.Parse("2023-06-28T05:50:59.509Z".ToString()),
                CurrencyRate=330,
                Price=40000000,
                Link="www.houce.lk"
               }
            };
            _houseDetailsServiceMock.Setup(s => s.GetHouseDetails()).Returns(Task.FromResult<IEnumerable<HouseDetailsSetDTO>>(GetHouses));

            var result = _houseController.GetHouse();

            var okResult = (OkObjectResult)result.Result;
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(GetHouses, okResult.Value);
        }

        [Test]
        public void UpdateHouseDetails()
        {
            int Id=1;
            var SuccessfulHouses = new HouseDetailsDTO
            {
                
                Location = "Piliyandala",
                NoOfBedRooms = 2,
                NoOfBathRooms = 3,
                LivingArea = 3000,
                LandArea = 9,
                floors = 2,
                School = 1,
                ShappingMall = 1,
                Transport = 1,
                Date = DateTime.Parse("2023-06-28T05:50:59.509Z".ToString()),
                CurrencyRate = 330,
                Price = 40000000,
                Link = "www.houce.lk"
            };

            var UnSuccessfulHouses= new HouseDetailsDTO
             {
                Location="Maharagama",
                NoOfBedRooms=2,
                NoOfBathRooms=3,
                LivingArea=3000,
                LandArea=9,
                floors=2,
                School=1,
                ShappingMall=1,
                Transport=1,
                Date = DateTime.Parse("2023-06-28T05:50:59.509Z".ToString()),
                CurrencyRate=330,
                Price=40000000,
                Link="www.houce.lk"
               
            };
           // _houseDetailsServiceMock.Setup(s => s.UpdateHouseDetails(Id,SuccessfulHouses).ReturnsAsync("Sucessfully Updated");

           // var resultSuccess = _houseController.updateHouse(GetHouses);
           // var resultExisting = _houseController.updateHouse()

            //Assert.IsInstanceOf<OkObjectResult>(resultSuccess.Result);
            //var okResultS = (OkObjectResult)resultSuccess.Result;
            //Assert.AreEqual(200, okResultS.StatusCode);
            //Assert.IsInstanceOf<OkObjectResult>(resultExisting.Result);
        }


    }
}
