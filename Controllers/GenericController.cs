using System.Collections.Generic;
using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagerApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class GenericController<T> : ControllerBase
  {
    private readonly IRepository<T> repository;

    public GenericController(IRepository<T> repository)
    {
      this.repository = repository;
    }

    [HttpGet]
    public IEnumerable<T> GetAllItems()
    {
      var items = repository.GetAllItems();
      return items;
    }

    [HttpGet("{id}")]
    public T GetItem(int id)
    {
      var item = repository.GetSingleItem(id);
      return item;
    }

    [HttpPost]
    public string AddItem(T item)
    {
      this.repository.AddItem(item);
      return "success";
    }

    [HttpPut("{id}")]
    public string UpdateItem(int id, T item)
    {
      this.repository.UpdateItem(item);
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