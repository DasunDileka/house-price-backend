using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Model
{
    public partial class HouseDetails
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int NoOfBedRoomS { get; set; }
        public int NoOfBathRooms { get; set; }
        public decimal LandSize { get; set; }
    }
}
