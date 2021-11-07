using System.Collections.Generic;
using cinema_manager_api.Models;
using cinema_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cinema_manager_api.Controllers
{
  public class UsersController : GenericController<User>
  {
    public UsersController(IRepository<User> repository) : base(repository) { }
  }
}