using house_price_backend_database.IRepository;
using house_price_backend_database.Model;
using house_price_backend_dto.DTO;
using System;
using System.Collections.Generic;
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
                    NoOfBedRoomS=houseDetailsDTO.NoOfBedRoomS,
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
    }
}
