using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class AuthRepository : ILoginRepository<User>
  {

    List<User> users = UsersData.users;

    public User login(string login, string password)
    {
      return users.Find(user => user.login.Equals(login) && user.password.Equals(password));
    }
  }
}