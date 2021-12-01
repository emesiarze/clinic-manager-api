using System;

namespace clinic_manager_api.Models
{
  public class Hall : IDatabaseItem<Hall>
  {
    public Guid id { get; init; }
    public string name { get; set; }

    public Hall(string name)
    {
      this.id = Guid.NewGuid();
      this.name = name;
    }

    public void Update(Hall item)
    {
      this.name = item.name;
    }
  }
}