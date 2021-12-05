using System;
using System.Collections.Generic;
using System.Linq;

namespace clinic_manager_api.Models
{
  public class Disease : IDatabaseItem<Disease>
  {
    public Disease(string name, List<Guid> symptomsIds)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptomsIds = symptomsIds;
    }

    public Disease(Disease disease)
    {
      this.id = disease.id;
      this.name = disease.name;
      this.symptomsIds = disease.symptomsIds;
    }

    public Disease(DiseaseDiagnoser disease)
    {
      this.id = disease.id;
      this.name = name;
      this.symptomsIds = symptomsIds;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public List<Guid> symptomsIds { get; set; }

    public void Update(Disease item)
    {
      this.name = item.name;
      this.symptomsIds = item.symptomsIds;
    }

    public override string ToString()
    {
      return name + ": " + symptomsIds.Count + "\nSymptoms: " + symptomsIds.Aggregate("", (prev, curr) => prev + " " + curr);
    }
  }

  public class DiseaseDiagnoser : Disease
  {
    public DiseaseDiagnoser(Disease disease) : base(disease) { }

    public float matchLevel { get; set; }

    public void countMatchLevel(Disease otherDisease)
    {
      int symptomsCountOfCurrentDisease = this.symptomsIds.Count;
      int symptomsCountOfOtherDisease = otherDisease.symptomsIds.Count;

      int numberOfMatchingSymptoms = otherDisease.symptomsIds.Aggregate(0, (sum, symptomId) => this.symptomsIds.Contains(symptomId) ? ++sum : sum);
      this.matchLevel = numberOfMatchingSymptoms * (1F / symptomsCountOfOtherDisease * 1F / symptomsCountOfCurrentDisease);
    }
  }

  public class DiseaseDto : IDataTransferObject
  {
    public DiseaseDto() { }

    public DiseaseDto(string name, List<Symptom> symptoms)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptoms = symptoms;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public List<Symptom> symptoms { get; set; }
  }
}