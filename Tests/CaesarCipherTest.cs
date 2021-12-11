using System;
using clinic_manager_api.Helpers;
using Xunit;

namespace Tests
{
  public class CaeasarCipherTest
  {
    [Fact]
    public void TestCaeasarCipher_ReturnsCorrectlyEncryptedPhrase()
    {
      string phrase = "abcd";
      string expectedResult = "hijk";
      string actualResult = RsaCryptographyService.Encrypt(phrase);

      Assert.True(actualResult == expectedResult);
    }

    [Fact]
    public void TestCaeasarCipher_ThrowsIncorrectCharactersException()
    {
      TestCaesarCipherExceptionMessage("ąbćd", "invalid_characters");
    }

    [Fact]
    public void TestCaeasarCipher_ThrowsEmptyPhraseException()
    {
      TestCaesarCipherExceptionMessage("", "empty_phrase");
    }

    public void TestCaesarCipherExceptionMessage(string testPhrase, string expectedExceptionMessage)
    {
      Action encryption = () => RsaCryptographyService.Encrypt(testPhrase);
      Exception exception = Assert.Throws<Exception>(encryption);
      Assert.Equal(expectedExceptionMessage, exception.Message);

    }
  }
}
