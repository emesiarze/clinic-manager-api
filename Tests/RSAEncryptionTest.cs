using System;
using clinic_manager_api.Helpers;
using Xunit;

namespace Tests
{
  public class RSAEncryptionTest
  {
    [Fact]
    public void TestRsaEncryption_ReturnsCorrectlyEncryptedPhrase()
    {
      string phrase = "abcd";
      string actualResult = RsaCryptographyService.Decrypt(RsaCryptographyService.Encrypt(phrase));

      Assert.True(actualResult == phrase);
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
