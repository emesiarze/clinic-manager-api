using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class UsersRepository : GenericRepository<User>
  {
    public override List<User> items
    {
      get
      {
        return new List<User>() {
          new User(1, "Jan Kowalski", "jankow", "qwer", false),
          new User(2, "Tomasz Malinowski", "tommal", "qwer", false),
          new User(3, "Jerzy Gwóźdź", "jegwoz", "qwer", true)
          // { id: 4, fullName: "Nick Adams", login: "nicada", password: "qwer", isWorker: false }    
        };
      }
    }
  }
}