using System;

namespace clinic_manager_api.Models
{
  public class Symptom : IDatabaseItem<Symptom>
  {
    public Guid id { get; init; }
    public string name { get; set; }

    public Symptom(string name)
    {
      this.id = Guid.NewGuid();
      this.name = name;
    }

    public void Update(Symptom item)
    {
      this.name = item.name;
    }
  }
}
