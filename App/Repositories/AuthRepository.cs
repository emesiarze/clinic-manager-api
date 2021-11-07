using System.Collections.Generic;
using cinema_manager_api.Data;
using cinema_manager_api.Models;

namespace cinema_manager_api.Repositories
{
  public class AuthRepository : ILoginRepository<User>
  {
    List<User> users = UsersData.items;

    public User login(string login, string password)
    {
      User user = users.Find(user => user.login.Equals(login) && user.password.Equals(password));
      if (user is null)
      {
        return null;
      }
      else
      {
        return new User(user);
      }
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