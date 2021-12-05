using System;
using System.Collections.Generic;
using System.Linq;
using clinic_manager_api.Models;
using clinic_manager_api.Data;
using clinic_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace clinic_manager_api.Controllers
{
  public class DiagnosesController : GenericController<Diagnose, DiagnoseDto>
  {
    public DiagnosesController(IRepository<Diagnose, DiagnoseDto> repository) : base(repository) { }


    [HttpGet("user")]
    public Response<IEnumerable<DiagnoseDto>> GetAllItems(Guid userId)
    {
      IEnumerable<DiagnoseDto> items = repository.GetAllItemsDto().ToList().FindAll(diagnose => diagnose.patient.id.Equals(userId));
      Response<IEnumerable<DiagnoseDto>> response = this.createResponse<IEnumerable<DiagnoseDto>>(items);

      return response;
    }

    [HttpPost("diagnose")]
    public Response<DiagnoseDto> Diagnose(DiagnoseDto unhandledDiagnose)
    {
      List<Symptom> symptoms = unhandledDiagnose.symptomsExperienced;
      IEnumerable<Guid> symptomsIds = symptoms.Select((symptom => symptom.id));
      Disease unknownDisease = new Disease("unknown", symptomsIds.ToList());

      // Map diseases to DiseaseDiagnoser
      List<DiseaseDiagnoser> diseasesWithMatchLevel = DiseasesData.items.Select(disease => new DiseaseDiagnoser(disease)).ToList();
      // Calculate match level
      diseasesWithMatchLevel.ForEach(diagnoser => diagnoser.countMatchLevel(unknownDisease));
      // Order diseases by match level
      diseasesWithMatchLevel = diseasesWithMatchLevel.OrderByDescending(disease => disease.matchLevel).ToList();
      // Get most matching disease
      Guid mostProbableDiseaseId = diseasesWithMatchLevel.First().id;
      // Save Diagnose to database
      Diagnose diagnose = new Diagnose(unhandledDiagnose.patient.id, unhandledDiagnose.doctor.id, mostProbableDiseaseId, symptomsIds.ToList(), DateTime.Now);
      DiagnosesData.items.Add(diagnose);

      DiagnoseDto diagnoseDto = this.repository.GetSingleItemDto(diagnose.id);

      return this.createResponse<DiagnoseDto>(diagnoseDto);
    }
  }
}