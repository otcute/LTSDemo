using System;
using Microsoft.Extensions.Configuration;

namespace DJ_UseCaseLayer.DAO
{
	public class Setting
	{
        public static string url()
        {
            return "Data Source=localhost;Initial Catalog=djxuyenc_ladatabase;User ID=djxuyenc_qa;password=Mamama99!@;encrypt=true;trustservercertificate=true;";
        }
    }
}

