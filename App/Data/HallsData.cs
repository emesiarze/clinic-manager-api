using System.Collections.Generic;
using clinic_manager_api.Models;

namespace clinic_manager_api.Data
{
  public static class HallsData
  {
    public static List<Symptom> items = new List<Symptom>() {
      new Symptom("1"),
      new Symptom("2"),
      new Symptom("3"),
      new Symptom("4"),
    };
  }
}
