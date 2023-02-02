using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTO
{
    internal class Setting
    {
        public static string connectServerUrl()
        {
            return "Data Source=localhost;Initial Catalog=laDatabase;Integrated Security=True;encrypt=true;trustservercertificate=true;";
        }
    }
}
