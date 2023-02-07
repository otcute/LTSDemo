using System;
using Microsoft.Extensions.Configuration;

namespace DJ_UseCaseLayer.DAO
{
	public class Setting
	{
        public static string url()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            var value = configuration.GetSection("ConnectString");
            return value.GetValue<string>("urlMacOS");
        }
    }
}

