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
        public decimal LivingArea { get; set; }
        public decimal LandArea { get; set; }
        public int floors { get; set; }
        public int School { get; set; }
        public int ShappingMall { get; set; }
        public int Transport { get; set; }
        public DateTime Date { get; set; }
        public int CurrencyRate { get; set; }
        public double Price { get; set; }
        public string? Link { get; set; }

    }
}
