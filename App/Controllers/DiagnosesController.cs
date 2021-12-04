using System;
using System.Collections.Generic;
using System.Linq;
using clinic_manager_api.Models;
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
  }
}