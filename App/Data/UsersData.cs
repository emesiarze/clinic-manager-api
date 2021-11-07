using System.Collections.Generic;
using cinema_manager_api.Models;

namespace cinema_manager_api.Data
{
  public static class UsersData
  {
    public static List<User> items = new List<User>() {
      new User("admin", "admin", "admin", true),
      new User("Jan Kowalski", "jankow", "asdf", false),
      new User("Adam Nowak", "adanow", "asdf", false),
      new User("Jerzy Gwóźdź", "jergwo", "asdf", false),
      new User("qwer", "qwer", "qwer", false),
      new User("asdf", "asdf", "asdf", false),
    };
  }
}