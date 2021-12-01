using System;
using System.Collections.Generic;

namespace clinic_manager_api.Models
{
  public class Diagnose : IDatabaseItem<Diagnose>
  {
    public Diagnose(Guid patientId, Guid doctorId, Guid diseaseId, List<Guid> symptomsExperiencedIds, DateTime diagnoseDate)
    {
      this.id = Guid.NewGuid();
      this.parientId = patientId;
      this.doctorId = doctorId;
      this.diseaseId = diseaseId;
      this.symptomsExperiencedIds = symptomsExperiencedIds;
      this.diagnoseDate = diagnoseDate;
    }

    public Guid id { get; init; }
    public Guid parientId { get; set; }
    public Guid doctorId { get; set; }
    public Guid diseaseId { get; set; }
    public List<Guid> symptomsExperiencedIds { get; set; }
    public DateTime diagnoseDate { get; set; }

    public void Update(Diagnose item)
    {
      this.parientId = item.parientId;
      this.doctorId = item.doctorId;
      this.diseaseId = item.diseaseId;
      this.symptomsExperiencedIds = item.symptomsExperiencedIds;
      this.diagnoseDate = item.diagnoseDate;
    }
  }

  public class DiagnoseDto : IDataTransferObject
  {
    public DiagnoseDto() { }

    public DiagnoseDto(Diagnose item)
    {
      this.id = item.id;
      this.diagnoseDate = item.diagnoseDate;
    }

    public DiagnoseDto(UserDto patient, UserDto doctor, DiseaseDto disease, List<Symptom> symptomsExperienced, DateTime diagnoseDate)
    {
      this.id = Guid.NewGuid();
      this.patient = patient;
      this.doctor = doctor;
      this.disease = disease;
      this.symptomsExperienced = symptomsExperienced;
      this.diagnoseDate = diagnoseDate;
    }

    public Guid id { get; init; }
    public UserDto patient { get; set; }
    public UserDto doctor { get; set; }
    public DiseaseDto disease { get; set; }
    public List<Symptom> symptomsExperienced { get; set; }
    public DateTime diagnoseDate { get; set; }
  }
}
