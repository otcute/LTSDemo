using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Properties.Address
{
    public class Commune :BaseEntity
    {
        public string? CommuneCode { get; set; }
        public string? CommuneName { get; set;}
    }
}
