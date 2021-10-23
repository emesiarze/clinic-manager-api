using System.Collections.Generic;
using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagerApi.Controllers
{
  public class UsersController : CommonController<User>
  {
    private readonly IRepository<User> repository;

    public UsersController(IRepository<User> repository) : base(repository)
    {
      this.repository = repository;
    }
  }
}