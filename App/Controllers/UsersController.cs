using System.Collections.Generic;
using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagerApi.Controllers
{
  public class UsersController : GenericController<User>
  {
    public UsersController(IRepository<User> repository) : base(repository) { }
  }
}