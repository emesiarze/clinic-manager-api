using System;
using System.Collections.Generic;
using System.IO;
using clinic_manager_api.Models;
using clinic_manager_api.Data;
using Newtonsoft.Json;
using System.Linq;

namespace clinic_manager_api.Helpers
{
  public class DatasetPopulator
  {
    private string fileName { get; set; }

    public DatasetPopulator(string fileName)
    {
      this.fileName = fileName;
    }

    public void PopulateDatabase()
    {
      System.Diagnostics.Debug.WriteLine("Reading from " + fileName);
      // Read data from JSON
      using (StreamReader r = new StreamReader(fileName))
      {
        string json = r.ReadToEnd();
        DatasetJsonModel items = (DatasetJsonModel)JsonConvert.DeserializeObject<DatasetJsonModel>(json);

        PopulateDatabaseWithSymptoms(items.allSymptoms);
        PopulateDatabaseWithDiseases(items.diseasesWithSymptoms);

        System.Diagnostics.Debug.WriteLine("Data inserted successfully.\n" + items.diseasesWithSymptoms.Count + " diseases total,\n" + items.allSymptoms.Count + " symptoms total.");
      }
    }

    private void PopulateDatabaseWithSymptoms(List<string> symptoms)
    {
      symptoms.ForEach((Action<string>)(symptom =>
      {
        SymptomsData.items.Add(new Symptom(symptom));
      }));
    }

    private void PopulateDatabaseWithDiseases(List<DiseaseJsonModel> diseasesJson)
    {
      diseasesJson.ForEach((Action<DiseaseJsonModel>)(diseaseJson =>
      {
        // Map symptoms names to ids
        List<Guid> symptomsIds = diseaseJson.symptoms.Select(symptomName =>
        {
          Symptom symptomObject = SymptomsData.items.Find((Predicate<Symptom>)(symptom => symptom.name.Equals(symptomName)));
          return symptomObject.id;
        }).ToList();

        DiseasesData.items.Add(new Disease(diseaseJson.name, symptomsIds));
      }));
    }
  }
}