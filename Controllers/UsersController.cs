using System.Collections.Generic;
using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagerApi.Controllers
{
  [ApiController]
  [Route("users")]
  public class UsersController : ControllerBase
  {
    private readonly IRepository<User> repository;

    public UsersController(IRepository<User> repository)
    {
      this.repository = repository;
    }

    [HttpGet]
    public IEnumerable<User> GetAllItems()
    {
      var users = repository.GetAllItems();
      return users;
    }

    [HttpGet("{id}")]
    public User GetItem(int id)
    {
      var user = repository.GetSingleItem(id);
      return user;
    }

    [HttpPost]
    public string AddItem(User user)
    {
      this.repository.AddItem(user);
      return "success";
    }

    [HttpPut("{id}")]
    public string UpdateItem(int id, User user)
    {
      this.repository.UpdateItem(user);
      return "success";
    }

    [HttpDelete("{id}")]
    public string DeleteItem(int id)
    {
      this.repository.DeleteItem(id);
      return "success";
    }
  }
}