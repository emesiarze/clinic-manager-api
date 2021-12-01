using System.Collections.Generic;
using clinic_manager_api.Models;

namespace clinic_manager_api.Data
{
  public static class UsersData
  {
    public static List<User> items = new List<User>() {
      new User("admin", "admin", "admin", true),
      new User("lek. Jan Kowalski", "ljankow", "asdf", true),
      new User("lek. Jose Mandalonez", "asdf", "asdf", true),
      new User("Adam Nowak", "adanow", "asdf", false),
      new User("Jerzy Gwóźdź", "jergwo", "asdf", false),
      new User("qwer", "qwer", "qwer", false),
    };
  }
}