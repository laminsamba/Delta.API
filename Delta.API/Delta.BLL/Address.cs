using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.BLL
{
    public class Address
    {
        public int AddressId { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
    }
}
