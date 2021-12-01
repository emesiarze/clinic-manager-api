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
      this.isDoctor = isWorker;
    }

    public User(User user)
    {
      this.id = user.id;
      this.fullName = user.fullName;
      this.login = user.login;
      this.isDoctor = user.isDoctor;
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
    public bool isDoctor { get; set; }

    public void Update(User item)
    {
      this.fullName = item.fullName;
      this.isDoctor = item.isDoctor;
    }
  }

  public class UserDto : IDataTransferObject
  {
    public UserDto(User user)
    {
      this.id = user.id;
      this.fullName = user.fullName;
      this.login = user.login;
      this.isDoctor = user.isDoctor;
    }

    public Guid id { get; init; }
    public string fullName { get; set; }
    public string login { get; set; }
    public bool isDoctor { get; set; }
  }
}