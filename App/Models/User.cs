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

    public User(string fullName, string login, string password, bool isDoctor, bool isAdmin)
    {
      this.id = Guid.NewGuid();
      this.fullName = fullName;
      this.login = login;
      this.password = password;
      this.isDoctor = isDoctor;
      this.isAdmin = isAdmin;
    }

    public User(User user)
    {
      this.id = user.id;
      this.fullName = user.fullName;
      this.login = user.login;
      this.isDoctor = user.isDoctor;
      this.isAdmin = user.isAdmin;
    }

    public Guid id { get; init; }
    public string fullName { get; set; }
    public string login { get; set; }
    public string password
    {
      get => RsaCryptographyService.Decrypt(_password);
      set
      {
        _password = RsaCryptographyService.Encrypt(value);
      }
    }
    public bool isDoctor { get; set; }
    public bool isAdmin { get; set; }

    public void Update(User item)
    {
      this.fullName = item.fullName;
      this.isDoctor = item.isDoctor;
      this.isAdmin = item.isAdmin;
    }
  }

  public class UserDto : IDataTransferObject
  {
    public UserDto() { }

    public UserDto(Guid id, string fullName, string login, bool isDoctor, bool isAdmin)
    {
      this.id = id;
      this.fullName = fullName;
      this.login = login;
      this.isDoctor = isDoctor;
      this.isAdmin = isAdmin;
    }
    public UserDto(User user)
    {
      this.id = user.id;
      this.fullName = user.fullName;
      this.login = user.login;
      this.password = "";
      this.isDoctor = user.isDoctor;
      this.isAdmin = user.isAdmin;
    }

    public Guid id { get; init; }
    public string fullName { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public bool isDoctor { get; set; }
    public bool isAdmin { get; set; }
  }
}