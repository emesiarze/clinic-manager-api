using System;
using System.Collections;

namespace cinema_manager_api.Helpers
{
  public class CaesarCipher
  {
    private static readonly int CIPHER_STEP = 7;
    private static readonly string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-=!@#$%^&*()_+[]\\;',./{}|:\"<>?";
    private static readonly char[] ALPHABET_CHAR_ARRAY = ALPHABET.ToCharArray();

    public static string Encrypt(string value)
    {
      bool isPhraseEmpty = value.Length == 0;
      if (!isPhraseEmpty && AreAllCharactersValid(value))
      {
        var result = "";
        foreach (char character in value)
          result += GetCorrespondingCharacter(character);
        return result;
      }
      else if (isPhraseEmpty)
      {
        throw new Exception("empty_phrase");
      }
      else
      {
        throw new Exception("invalid_characters");
      }
    }

    private static bool AreAllCharactersValid(string value)
    {
      int counter = 0;

      foreach (char character in value)
        if (ALPHABET.Contains(character.ToString())) counter++;

      return counter == value.Length;
    }

    private static char GetCorrespondingCharacter(char character)
    {
      int indexOfChar = Array.IndexOf(ALPHABET_CHAR_ARRAY, character);
      return ALPHABET_CHAR_ARRAY[(indexOfChar + CIPHER_STEP) % ALPHABET_CHAR_ARRAY.Length];
    }
  }
}