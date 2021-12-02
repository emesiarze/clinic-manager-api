using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinic_manager_api.Data;
using clinic_manager_api.Helpers;
using clinic_manager_api.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace clinic_manager_api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      InitializeDatasets();
      CreateHostBuilder(args).Build().Run();
    }

    public static void InitializeDatasets()
    {
      DatasetPopulator populator = new DatasetPopulator("./App/Assets/complete_data.json");
      populator.PopulateDatabase();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
