using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs
{
    [Route("api")]
    [ApiController]

    public class BaseAPI : ControllerBase
    {
        public static string url()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            var value = configuration.GetSection("ConnectString");
            return value.GetValue<string>("urlMacOS");
        }
    }
}
