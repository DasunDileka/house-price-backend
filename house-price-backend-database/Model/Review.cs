using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Model
{
    public partial class Review
    {
        public virtual User User { get; set; }
        public int Id { get; set; }
        public string comment { get; set; }
    }
}
