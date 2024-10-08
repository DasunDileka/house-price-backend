﻿using house_price_backend_database.IRepository;
using house_price_backend_database.Model;
using house_price_backend_dto.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Repository
{
    public  class HouseDetailsRepository:IHouseDetailsRepository
    {
        private readonly HouseContext _context;

        public HouseDetailsRepository(HouseContext context)
        { 
            _context = context;
        }

        public async Task<bool> EnterHouseDetails(HouseDetailsDTO houseDetailsDTO)
        {
            try
            {
                var house = new HouseDetails()
                {
                    Location = houseDetailsDTO.Location,
                    NoOfBathRooms=houseDetailsDTO.NoOfBathRooms,
                    NoOfBedRoomS=houseDetailsDTO.NoOfBedRooms,
                    LivingArea=houseDetailsDTO.LivingArea,
                    LandArea=houseDetailsDTO.LandArea,
                    floors=houseDetailsDTO.floors,
                    School=houseDetailsDTO.School,
                    ShappingMall=houseDetailsDTO.ShappingMall,
                    Transport=houseDetailsDTO.Transport,
                    Date=houseDetailsDTO.Date,
                    CurrencyRate=houseDetailsDTO.CurrencyRate,
                    Price=houseDetailsDTO.Price,
                    Link=houseDetailsDTO.Link,

                };

                _context.HouseDetails.Add(house);
                await _context.SaveChangesAsync();
                return true;
            }catch (Exception ex)
            {
                throw;
            }

        }


        public async Task<IEnumerable<HouseDetailsSetDTO>> GetHouseDetails()
        {
            try
            {
                var result = await _context.HouseDetails
                    .Select(e => new HouseDetailsSetDTO
                    {
                        Id=e.Id,
                        Location = e.Location,
                        NoOfBathRooms = e.NoOfBathRooms,
                        NoOfBedRooms = e.NoOfBedRoomS,
                        LivingArea = e.LivingArea,
                        LandArea = e.LandArea,
                        floors = e.floors,
                        School = e.School,
                        ShappingMall = e.ShappingMall,
                        Transport = e.Transport,
                        Date = e.Date,
                        CurrencyRate = e.CurrencyRate,
                        Price = e.Price,
                        Link = e.Link,
                    })
                    .ToListAsync();

                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateHouseDetails(int Id, HouseDetailsDTO houseDetailsDTO)
        {
            try
            {

                var house = await _context.HouseDetails.Where(e => e.Id == Id).FirstOrDefaultAsync();

                house.Location = houseDetailsDTO.Location;
                house.NoOfBathRooms = houseDetailsDTO.NoOfBathRooms;
                house.NoOfBedRoomS = houseDetailsDTO.NoOfBedRooms;
                house.LivingArea = houseDetailsDTO.LivingArea;
                house.LandArea = houseDetailsDTO.LandArea;
                house.floors = houseDetailsDTO.floors;
                house.School = houseDetailsDTO.School;
                house.ShappingMall = houseDetailsDTO.ShappingMall;
                house.Transport = houseDetailsDTO.Transport;
                house.Date = houseDetailsDTO.Date;
                house.CurrencyRate = houseDetailsDTO.CurrencyRate;
                house.Price = houseDetailsDTO.Price;
                house.Link = houseDetailsDTO.Link;

                _context.HouseDetails.Update(house);
                _context.SaveChanges();
                return true;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UploadFile(IFormFile file, string location, int numberOfBedrooms, int numberOfBathrooms, decimal livingAreaSize, decimal landSize, decimal price, int contact, int userId)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return false;
                }

                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    var fileData = memoryStream.ToArray();

                    var Id = _context.Users.Where(e => e.Id == userId).FirstOrDefault();

                    var fileUpload = new Image
                    {
                        location = location,
                        numberOfBathrooms = numberOfBathrooms,
                        numberOfBedrooms = numberOfBedrooms,
                        livingAreaSize = livingAreaSize,
                        landSize = landSize,
                        contact = contact,
                        price = price,
                        image = fileData,
                        User = Id

                    };

                    _context.Images.Add(fileUpload);
                    await _context.SaveChangesAsync();

                    return true;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<AddImage>> GetFile()
        {

            var data = await _context
                .Images
                .Select(e=>new AddImage
                {
                    location=e.location,
                    numberOfBathrooms=e.numberOfBathrooms,
                    numberOfBedrooms=e.numberOfBedrooms,
                    livingAreaSize=e.livingAreaSize,
                    landSize=e.landSize,
                    contact = e.contact,
                    price = e.price,             
                    image= Convert.ToBase64String(e.image)

                }).
                ToListAsync();   

          return data;

        }

    }
}
