using house_price_backend_database.IRepository;
using house_price_backend_database.Repository;
using house_price_backend_dto.DTO;
using house_price_backend_service.IService;
using Microsoft.AspNetCore.Http;
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

        public async Task<IEnumerable<HouseDetailsSetDTO>> GetHouseDetails()
        {
            var gethouse = await _houseDetailsRepository.GetHouseDetails();
            return gethouse;
        }

        public async Task<bool> UpdateHouseDetails(int Id, HouseDetailsDTO houseDetailsDTO)
        {
            var updatehouse=await _houseDetailsRepository.UpdateHouseDetails(Id, houseDetailsDTO);
            return updatehouse;
        }

        public async Task<bool> UploadFile(IFormFile file, string location, int numberOfBedrooms, int numberOfBathrooms, decimal livingAreaSize, decimal landSize, decimal price,int contact,int userId)
        {
            var updatehouse = await _houseDetailsRepository.UploadFile(file, location, numberOfBedrooms, numberOfBathrooms, livingAreaSize, landSize, price, contact, userId);
            return updatehouse;
        }
        public Task<List<AddImage>> GetFile()
        {
            var file =_houseDetailsRepository.GetFile();
            return file;
        }
    }
}
