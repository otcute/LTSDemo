using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.DAO
{
    public class Setting
    {
        public static string connectServerUrl()
        {
            return "Data Source=localhost;Initial Catalog=laDatabase;Integrated Security=True;encrypt=true;trustservercertificate=true;";
        }
        public static string connectServerUrlMacOS()
        {
            return "Data Source=localhost;Initial Catalog=laDatabase;User ID= sa;Password = Mamama99!;encrypt=true;trustservercertificate=true;";
        }
        public static string connectServerUrlHostDB()
        {
            return "Data Source=103.216.113.32;Initial Catalog=djxuyenc;User ID= djxuyenc_qa;Password = Mamama99!@;encrypt=true;trustservercertificate=true;";
        }
    }
}
