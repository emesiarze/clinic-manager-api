using System;
using System.Collections.Generic;
using System.Linq;
using clinic_manager_api.Models;
using clinic_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace clinic_manager_api.Controllers
{
  public class UsersController : GenericController<User, UserDto>
  {
    public UsersController(IRepository<User, UserDto> repository) : base(repository) { }


    [HttpGet("patients")]
    public Response<IEnumerable<UserDto>> GetAllPatients()
    {
      IEnumerable<UserDto> items = repository.GetAllItemsDto().ToList().FindAll((Predicate<UserDto>)(user => !user.isDoctor && !user.isAdmin));
      Response<IEnumerable<UserDto>> response = this.createResponse<IEnumerable<UserDto>>(items);

      return response;
    }

    [HttpGet("doctors")]
    public Response<IEnumerable<UserDto>> GetAllDoctors()
    {
      IEnumerable<UserDto> items = repository.GetAllItemsDto().ToList().FindAll((Predicate<UserDto>)(user => user.isDoctor));
      Response<IEnumerable<UserDto>> response = this.createResponse<IEnumerable<UserDto>>(items);

      return response;
    }
  }
}