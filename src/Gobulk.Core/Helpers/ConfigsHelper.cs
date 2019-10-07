using Microsoft.Extensions.Configuration;
using System.IO;

namespace Gobulk.Core.Helpers
{
    public static class ConfigsHelper
    {
        private static IConfiguration _configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();


        public static string DB_CONNECTION => _configuration["DBConnection"];
    }
}
