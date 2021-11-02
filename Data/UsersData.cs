using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class UsersData
  {
    public static List<User> items = new List<User>() {
      new User("Admin", "asdf", "asdf", true),
      new User("Jan Kowalski", "jankow", "asdf", false),
      new User("Adam Nowak", "adanow", "asdf", false),
      new User("Jerzy Gwóźdź", "jergwo", "asdf", false)
    };
  }
}