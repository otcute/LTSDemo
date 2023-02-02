using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Properties
{
    public class Address
    {
        public int AddressId { get; set; }
        public int CommuneId { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }

    }
}
