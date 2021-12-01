using System;

namespace clinic_manager_api.Models
{
  public class Disease : IDatabaseItem<Disease>
  {
    public Disease(string name, Guid[] symptomsIds)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptomsIds = symptomsIds;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public Guid[] symptomsIds { get; set; }

    public void Update(Disease item)
    {
      this.name = item.name;
      this.symptomsIds = item.symptomsIds;
    }
  }

  public class DiseaseDto
  {
    public DiseaseDto(string name, Symptom[] symptoms)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptoms = symptoms;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public Symptom[] symptoms { get; set; }
  }
}