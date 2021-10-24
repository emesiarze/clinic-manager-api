namespace CinemaManagerApi.Models
{
  public class User : IDatabaseItem<User>
  {
    public User(int id, string fullName, string login, string password, bool isWorker)
    {
      this.id = id;
      this.fullName = fullName;
      this.login = login;
      this.password = password;
      this.isWorker = isWorker;
    }

    public int id { get; set; }
    public string fullName { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public bool isWorker { get; set; }

    public void Update(User item)
    {
      this.fullName = item.fullName;
      this.login = item.login;
      this.password = item.password;
      this.isWorker = item.isWorker;
    }
  }
}