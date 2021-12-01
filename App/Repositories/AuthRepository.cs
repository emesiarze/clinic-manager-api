using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Helpers;
using clinic_manager_api.Models;
using System.Linq;

namespace clinic_manager_api.Repositories
{
  public class AuthRepository : ILoginRepository<User>
  {
    List<User> users = UsersData.items;

    public User login(string login, string password)
    {

      string encryptedPassword = CaesarCipher.Encrypt(password);

      var query = from qUser in users
                  where qUser.login == login && qUser.password == encryptedPassword
                  select qUser;

      if (query.Any<User>())
      {
        User user = query.ElementAt<User>(0);
        return new User(user);
      }
      else
      {
        return null;
      }
    }

    public string DoesLoginExists(string login)
    {
      try
      {
        var usersQuery = from qUser in users
                         where qUser.login == login
                         select qUser;

        string result = usersQuery.Any<User>() ? "exists" : "not_exists";
        return result;
      }
      catch
      {
        return "error";
      }
    }
  }
}