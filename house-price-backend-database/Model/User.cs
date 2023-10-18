﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string UserType { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Image>? Images { get; set; }
    }
}
