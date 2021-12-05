using System;
using System.Collections.Generic;
using System.Linq;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  public class DiagnosesRepository : GenericRepository<Diagnose, DiagnoseDto>
  {
    public override List<Diagnose> items
    {
      get
      {
        return DiagnosesData.items;
      }
    }

    override public DiagnoseDto GetSingleItemDto(Guid id)
    {
      Diagnose item = base.GetSingleItem(id);

      User patient = UsersData.items.Find((Predicate<User>)(doc => (bool)doc.id.Equals(item.parientId)));
      User doctor = UsersData.items.Find((Predicate<User>)(doc => (bool)doc.id.Equals(item.doctorId)));
      Disease disease = DiseasesData.items.Find((Predicate<Disease>)(dise => (bool)dise.id.Equals(item.diseaseId)));

      List<Symptom> symptomsExperienced = new List<Symptom>();
      item.symptomsExperiencedIds.ForEach((Action<Guid>)(symptomId =>
      {
        Symptom symptom = SymptomsData.items.Find(
          (Predicate<Symptom>)(sympt => (bool)sympt.id.Equals(symptomId))
        );
        symptomsExperienced.Add(symptom);
      }));

      List<Symptom> diseaseSymptoms = new List<Symptom>();
      disease.symptomsIds.ForEach((Action<Guid>)(symptomId =>
      {
        Symptom symptom = SymptomsData.items.Find(
          (Predicate<Symptom>)(sympt => (bool)sympt.id.Equals(symptomId))
        );
        diseaseSymptoms.Add(symptom);
      }));

      DiagnoseDto result = new DiagnoseDto(item);
      result.patient = new UserDto(patient);
      result.doctor = new UserDto(doctor);
      result.symptomsExperienced = symptomsExperienced;
      result.disease = new DiseaseDto(disease.name, diseaseSymptoms);

      return result;
    }

    override public IEnumerable<DiagnoseDto> GetAllItemsDto()
    {
      IEnumerable<DiagnoseDto> allItemsDto = this.items.Select(item =>
      {
        User patient = UsersData.items.Find((Predicate<User>)(doc => (bool)doc.id.Equals(item.parientId)));
        User doctor = UsersData.items.Find((Predicate<User>)(doc => (bool)doc.id.Equals(item.doctorId)));
        Disease disease = DiseasesData.items.Find((Predicate<Disease>)(dise => (bool)dise.id.Equals(item.diseaseId)));

        List<Symptom> symptomsExperienced = new List<Symptom>();
        item.symptomsExperiencedIds.ForEach((Action<Guid>)(symptomId =>
        {
          Symptom symptom = SymptomsData.items.Find(
            (Predicate<Symptom>)(sympt => (bool)sympt.id.Equals(symptomId))
          );
          symptomsExperienced.Add(symptom);
        }));

        List<Symptom> diseaseSymptoms = new List<Symptom>();
        disease.symptomsIds.ForEach((Action<Guid>)(symptomId =>
        {
          Symptom symptom = SymptomsData.items.Find(
            (Predicate<Symptom>)(sympt => (bool)sympt.id.Equals(symptomId))
          );
          diseaseSymptoms.Add(symptom);
        }));

        DiagnoseDto result = new DiagnoseDto(item);
        result.patient = new UserDto(patient);
        result.doctor = new UserDto(doctor);
        result.symptomsExperienced = symptomsExperienced;
        result.disease = new DiseaseDto(disease.name, diseaseSymptoms);

        return result;
      });

      return allItemsDto.OrderByDescending(x => x.diagnoseDate);
    }
  }
}