using house_price_backend_database.Model;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using house_price_backend_service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace house_price_backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseDetailsService _houseDetailsService;

        public HouseController(IHouseDetailsService houseDetailsService)
        {
            _houseDetailsService = houseDetailsService;
        }
        [HttpPost("NewHouseDetails")]
        public async Task<IActionResult> EnterDetails(HouseDetailsDTO houseDetailsDTO)
        {
            var result = await _houseDetailsService.EnterHouseData(houseDetailsDTO);
            if(result==true)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetHouseDetails")]
        public async Task<IActionResult> GetHouse()
        {
            var result = await _houseDetailsService.GetHouseDetails();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("updateHouseDetails")]
        public async Task<IActionResult> updateHouse(int Id, HouseDetailsDTO houseDetailsDTO)
        {
            var result = await _houseDetailsService.UpdateHouseDetails(Id, houseDetailsDTO);
            if(result==true)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile formFile, string location, int numberOfBedrooms, int numberOfBathrooms,decimal livingAreaSize, decimal landSize, decimal price, int contact, int userId)
        {

            try
            {
                var responce = await _houseDetailsService.UploadFile(formFile, location,numberOfBedrooms,numberOfBathrooms,livingAreaSize,landSize,price, contact, userId);
                if(responce==true)
                {
                    return Ok(responce);
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet("GetImages")]
        public async Task<IActionResult> GetAllImages()
        {

            try
            {
                var responce = await _houseDetailsService.GetFile();              
                return Ok(responce);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
