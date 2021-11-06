using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class AuthRepository : ILoginRepository<User>
  {
    List<User> users = UsersData.items;

    public User login(string login, string password)
    {
      User user = users.Find(user => user.login.Equals(login) && user.password.Equals(password));
      return new User(user);
    }

    public string DoesLoginExists(string login)
    {
      try
      {
        User user = this.users.Find(u => u.login.Equals(login));
        string result = (user is null) ? "not_exists" : "exists";
        return result;
      }
      catch
      {
        return "error";
      }
    }
  }
}