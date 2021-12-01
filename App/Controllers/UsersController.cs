using System.Collections.Generic;
using clinic_manager_api.Models;
using clinic_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace clinic_manager_api.Controllers
{
  public class UsersController : GenericController<User, UserDto>
  {
    public UsersController(IRepository<User, UserDto> repository) : base(repository) { }
  }
}