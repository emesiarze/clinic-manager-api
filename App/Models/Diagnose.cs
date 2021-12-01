using System;

namespace clinic_manager_api.Models
{
  public class Diagnose : IDatabaseItem<Diagnose>
  {
    public Diagnose(Guid userId, Guid doctorId, Guid diseaseId, Guid[] symptomsExperiencedIds, DateTime diagnoseDate)
    {
      this.id = Guid.NewGuid();
      this.userId = userId;
      this.doctorId = doctorId;
      this.diseaseId = diseaseId;
      this.symptomsExperiencedIds = symptomsExperiencedIds;
      this.diagnoseDate = diagnoseDate;
    }

    public Guid id { get; init; }
    public Guid userId { get; set; }
    public Guid doctorId { get; set; }
    public Guid diseaseId { get; set; }
    public Guid[] symptomsExperiencedIds { get; set; }
    public Disease disease { get; set; }
    public Symptom[] symptomsExperienced { get; set; }
    public DateTime diagnoseDate { get; set; }

    public void Update(Diagnose item)
    {
      this.userId = item.userId;
      this.doctorId = item.doctorId;
      this.diseaseId = item.diseaseId;
      this.symptomsExperiencedIds = item.symptomsExperiencedIds;
      this.diagnoseDate = item.diagnoseDate;
    }
  }

  public class DiagnoseDto
  {
    public DiagnoseDto(UserDto userId, UserDto doctorId, DiseaseDto disease, Symptom[] symptomsExperienced, DateTime diagnoseDate)
    {
      this.id = Guid.NewGuid();
      this.user = userId;
      this.doctor = doctorId;
      this.disease = disease;
      this.symptomsExperienced = symptomsExperienced;
      this.diagnoseDate = diagnoseDate;
    }

    public Guid id { get; init; }
    public UserDto user { get; set; }
    public UserDto doctor { get; set; }
    public DiseaseDto disease { get; set; }
    public Symptom[] symptomsExperienced { get; set; }
    public DateTime diagnoseDate { get; set; }
  }
}
