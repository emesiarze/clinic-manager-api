namespace CinemaManagerApi.Models
{
  public class User
  {
    public int id { get; set; }
    public string fullName { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public bool isWorker { get; set; }
  }
}