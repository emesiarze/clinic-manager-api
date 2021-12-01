using System;

namespace clinic_manager_api.Models
{
  public interface IDataTransferObject
  {
    Guid id { get; init; }
  }
}