using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace cinema_manager_api
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
      InitializeSeanses();
    }

    private static void InitializeSeanses()
    {
      System.Diagnostics.Debug.WriteLine("Populating seanses");
      List<Hall> halls = HallsData.items;
      List<Movie> movies = MoviesData.items;

      int minIndex = Math.Min(halls.Count<Hall>(), movies.Count<Movie>());
      for (int i = 0; i < minIndex; i++)
      {
        SeanseData.items.Add(new Seanse(movies[i].id, halls[i].id, new DateTime()));
      }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
