using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace TyrellCorp
{
    
    public static class Configurations
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.ConfigureAppConfiguration(config =>
            {
                // Retrieve the connection string
                IConfiguration settings = config.Build();
                string connectionString = settings.GetConnectionString("AppConfig");

                // Load configuration from Azure App Configuration
                config.AddAzureAppConfiguration(connectionString);
            });

           // webBuilder.UseStartup<Startup>();
        });


    }
}
