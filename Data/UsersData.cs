using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class UsersData
  {
    public static List<User> items = new List<User>() {
    new User("Jan Kowalski", "jankow", "qwer", false),
    new User("Tomasz Malinowski", "tommal", "qwer", false),
    new User("Jerzy Gwóźdź", "jegwoz", "qwer", true)
    // { id: 4, fullName: "Nick Adams", login: "nicada", password: "qwer", isWorker: false }    
  };
  }
}