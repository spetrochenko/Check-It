using Microsoft.Extensions.Configuration;
using System.IO;

namespace CI.Common.Helpers.DbContextHelpers
{
    public static class DbContextHelper
    {
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory() + "/Configs");

            builder.AddJsonFile("connectionStringConfig.json");

            var config = builder.Build();

            return config.GetConnectionString("DefaultConnection");
        }
    }
}
