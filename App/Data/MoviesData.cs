using System.Collections.Generic;
using clinic_manager_api.Models;

namespace clinic_manager_api.Data
{
  public static class MoviesData
  {
    public static List<Symptom> items = new List<Symptom>() {
      new Symptom("Jan Makłowicz", "Ratatuj", 123),
      new Symptom("Stefan Gragóra", "Łocz dis", 160),
      new Symptom("Adam Handler", "Togres", 95),
      new Symptom("Swift Kieliver", "S.J.O.T.", 102),
    };
  }
}
