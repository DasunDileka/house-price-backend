﻿using house_price_backend_dto.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.IRepository
{
    public interface IHouseDetailsRepository
    {
        Task<bool> EnterHouseDetails(HouseDetailsDTO houseDetailsDTO);
        Task<IEnumerable<HouseDetailsSetDTO>> GetHouseDetails();
        Task<bool> UpdateHouseDetails(int Id,HouseDetailsDTO houseDetailsDTO);
        Task<bool> UploadFile(IFormFile file, string location, int numberOfBedrooms, int numberOfBathrooms, decimal livingAreaSize, decimal landSize, decimal price,int contact);
        Task<List<AddImage>> GetFile();
    }
}
