using System.Collections.Generic;

namespace clinic_manager_api.Models
{
  public class DatasetJsonModel
  {
    public List<DiseaseJsonModel> diseasesWithSymptoms { get; set; }
    public List<string> allDiseases { get; set; }
    public List<string> allSymptoms { get; set; }
  }

  public class DiseaseJsonModel
  {
    public string name { get; set; }
    public List<string> symptoms { get; set; }
  }
}