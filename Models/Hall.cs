namespace CinemaManagerApi.Models
{
  public class Hall : IDatabaseItem<Hall>
  {
    public Hall(int id, int number)
    {
      this.id = id;
      this.number = number;
    }

    public int id { get; set; }
    public int number { get; set; }

    public void Update(Hall item)
    {
      this.number = number;
    }
  }
}