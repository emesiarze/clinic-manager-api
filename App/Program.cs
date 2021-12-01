using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinic_manager_api.Data;
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
      InitializeSeanses();
      InitializeReservations();
    }

    private static void InitializeSeanses()
    {
      System.Diagnostics.Debug.WriteLine("Populating seanses");
      List<Symptom> halls = HallsData.items;
      List<Symptom> movies = MoviesData.items;

      Random rand = new Random();
      // DateTime date = new DateTime();

      int minIndex = Math.Min(halls.Count<Symptom>(), movies.Count<Symptom>());
      for (int i = 0; i < minIndex; i++)
      {
        DateTime date = DateTime.Now;
        date.AddDays(rand.Next(0, 5));
        date.AddHours(rand.Next(0, 5));
        date.AddMinutes(rand.Next(0, 59));
        SeansesData.items.Add(new Diagnose(movies[i].id, halls[i].id, date));
      }
    }

    private static void InitializeReservations()
    {
      System.Diagnostics.Debug.WriteLine("Creating reservations");
      List<Diagnose> seanses = SeansesData.items;
      List<User> users = UsersData.items;

      int minIndex = Math.Min(seanses.Count<Diagnose>(), users.Count<User>());
      for (int i = 0; i < minIndex; i++)
      {
        ReservationsData.items.Add(new Reservation(users[i].id, seanses[i].id, i, DateTime.Now, false));
        ReservationsData.items.Add(new Reservation(users[i].id, seanses[i].id, i + 1, DateTime.Now, false));
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
