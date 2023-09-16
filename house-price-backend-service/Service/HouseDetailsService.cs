using house_price_backend_database.IRepository;
using house_price_backend_database.Repository;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_service.Service
{
    public class HouseDetailsService:IHouseDetailsService
    {
        private readonly IHouseDetailsRepository _houseDetailsRepository;
        public HouseDetailsService(IHouseDetailsRepository houseDetailsRepository) 
        { 
            _houseDetailsRepository = houseDetailsRepository;
        }

        public async Task<bool> EnterHouseData(HouseDetailsDTO houseDetailsDTO)
        {
            var houseData=await _houseDetailsRepository.EnterHouseDetails(houseDetailsDTO);
            return houseData;
        }
    }
}
