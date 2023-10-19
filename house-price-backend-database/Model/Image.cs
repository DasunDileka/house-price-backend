﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Model
{
    public partial class Image
    {
        public int Id { get; set; }
        public string location { get; set; }
        public int numberOfBedrooms { get; set; }
        public int numberOfBathrooms { get; set; }
        public decimal livingAreaSize { get; set; }
        public decimal landSize { get; set; }
        public decimal price { get; set; }
        public int contact { get; set; }
        public byte[]? image { get; set; }
        public virtual User? User { get; set; }
    }
}
