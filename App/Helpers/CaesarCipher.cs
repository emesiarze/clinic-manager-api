using System;

namespace CinemaManagerApi.Helpers
{
  public class CaesarCipher
  {
    private static readonly int CIPHER_STEP = 7;
    private static readonly string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-=!@#$%^&*()_+";

    public static string Encrypt(string value)
    {
      var splitValue = value.Split();
      int counter = 0;

      foreach (var character in splitValue)
        if (ALPHABET.Contains(character)) counter++;

      if (counter == value.Length)
      {
        string result = "";
        foreach (var character in splitValue) result += GetCorrespondingCharacter(character);
        return result;
      }
      else
      {
        throw new Exception("invalid_characters");
      }
    }

    private static char GetCorrespondingCharacter(string character)
    {
      int indexOfChar = ALPHABET.IndexOf(character);
      return ALPHABET[(indexOfChar + CIPHER_STEP) % ALPHABET.Length - 1];
    }
  }
}