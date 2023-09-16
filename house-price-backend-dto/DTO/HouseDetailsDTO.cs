using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_dto.DTO
{
    public class HouseDetailsDTO
    {
        public string Location { get; set; }
        public int NoOfBedRoomS { get; set; }
        public int NoOfBathRooms { get; set; } 
        public decimal LandSize { get; set; }

    }
}
