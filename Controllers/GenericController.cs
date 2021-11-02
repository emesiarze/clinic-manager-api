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
    public Response<IEnumerable<T>> GetAllItems()
    {
      IEnumerable<T> items = repository.GetAllItems();
      Response<IEnumerable<T>> response = new Response<IEnumerable<T>>();
      response.data = items;
      response.isSuccess = items is not null;

      return response;
    }

    [HttpGet]
    public Response<T> GetItem(Guid id)
    {
      T item = repository.GetSingleItem(id);
      Response<T> response = new Response<T>();
      response.data = item;
      response.isSuccess = item is not null;

      return response;
    }

    [HttpPost]
    public Response<string> AddItem(T item)
    {
      string result = this.repository.AddItem(item);
      Response<string> response = new Response<string>();
      response.isSuccess = result == "success";

      return response;
    }

    [HttpPut]
    public Response<string> UpdateItem(T item)
    {
      string result = this.repository.UpdateItem(item);
      Response<string> response = new Response<string>();
      response.isSuccess = result == "success";

      return response;
    }

    [HttpDelete]
    public Response<string> DeleteItem(Guid id)
    {
      string result = this.repository.DeleteItem(id);
      Response<string> response = new Response<string>();
      response.isSuccess = result == "success";

      return response;
    }
  }
}