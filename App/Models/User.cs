using System;
using clinic_manager_api.Helpers;

namespace clinic_manager_api.Models
{
  public class User : IDatabaseItem<User>
  {
    private string _password;

    public User()
    {
      this.id = Guid.NewGuid();
    }

    public User(string fullName, string login, string password, bool isWorker)
    {
      this.id = Guid.NewGuid();
      this.fullName = fullName;
      this.login = login;
      this.password = password;
      this.isWorker = isWorker;
    }

    public User(User user)
    {
      this.id = user.id;
      this.fullName = user.fullName;
      this.login = user.login;
      this.isWorker = user.isWorker;
    }

    public Guid id { get; init; }
    public string fullName { get; set; }
    public string login { get; set; }
    public string password
    {
      get => _password;
      set
      {
        _password = CaesarCipher.Encrypt(value);
      }
    }
    public bool isWorker { get; set; }

    public void Update(User item)
    {
      this.fullName = item.fullName;
      this.isWorker = item.isWorker;
    }
  }
}