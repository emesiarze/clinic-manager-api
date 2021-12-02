using System;
using System.Collections.Generic;
using clinic_manager_api.Models;
using clinic_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace clinic_manager_api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class GenericController<T, TDto> : ControllerBase
  {
    protected readonly IRepository<T, TDto> repository;

    public GenericController(IRepository<T, TDto> repository)
    {
      this.repository = repository;
    }

    [HttpGet("all")]
    public Response<IEnumerable<TDto>> GetAllItems()
    {
      IEnumerable<TDto> items = repository.GetAllItemsDto();
      Response<IEnumerable<TDto>> response = this.createResponse<IEnumerable<TDto>>(items);

      return response;
    }

    [HttpGet]
    public Response<TDto> GetItem(Guid id)
    {
      TDto item = repository.GetSingleItemDto(id);
      Response<TDto> response = this.createResponse<TDto>(item);

      return response;
    }

    [HttpPost]
    public Response<string> AddItem(T item)
    {
      string result = this.repository.AddItem(item);
      Response<string> response = this.createResponse(result);

      return response;
    }

    [HttpPut]
    public Response<string> UpdateItem(T item)
    {
      string result = this.repository.UpdateItem(item);
      Response<string> response = this.createResponse(result);

      return response;
    }

    [HttpDelete]
    public Response<string> DeleteItem(Guid id)
    {
      string result = this.repository.DeleteItem(id);
      Response<string> response = this.createResponse(result);

      return response;
    }

    private Response<string> createResponse(string result)
    {
      Response<string> response = new Response<string>();
      response.isSuccess = result == "success";
      response.errorMessage = !response.isSuccess ? result : null;

      return response;
    }

    private Response<R> createResponse<R>(R item)
    {
      Response<R> response = new Response<R>();
      response.data = item;
      response.isSuccess = item is not null;

      return response;
    }
  }
}