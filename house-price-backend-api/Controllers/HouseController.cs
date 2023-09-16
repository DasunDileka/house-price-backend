﻿using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using house_price_backend_service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return Ok();
            }
            return BadRequest();
        }
    }
}
