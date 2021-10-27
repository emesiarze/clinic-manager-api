using System;
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

    [HttpGet("all")]
    public IEnumerable<T> GetAllItems()
    {
      var items = repository.GetAllItems();
      return items;
    }

    [HttpGet]
    public T GetItem(Guid id)
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

    [HttpPut]
    public string UpdateItem(int id, T item)
    {
      this.repository.UpdateItem(item);
      return "success";
    }

    [HttpDelete]
    public string DeleteItem(Guid id)
    {
      this.repository.DeleteItem(id);
      return "success";
    }
  }
}