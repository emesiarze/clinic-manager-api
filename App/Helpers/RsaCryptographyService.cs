using System;
using System.Security.Cryptography;
using System.Text;

namespace clinic_manager_api.Helpers
{
  public class RsaCryptographyService
  {
    private static readonly RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

    static public string Encrypt(string value)
    {
      if (value != "")
      {
        try
        {
          return RSAEncrypt(value, rsa.ExportParameters(false), false);
        }
        catch (ArgumentNullException)
        {
          Console.WriteLine("Encryption failed.");
          return null;
        }
      }
      else throw new Exception(message: "empty_phrase");
    }

    static public string Decrypt(string encryptedData)
    {
      try
      {
        return RSADecrypt(encryptedData, rsa.ExportParameters(true), false);
      }
      catch (ArgumentNullException)
      {
        Console.WriteLine("Encryption failed.");
        return null;
      }
    }

    public static string RSAEncrypt(string dataToEncrypt, RSAParameters rsaKeyInfo, bool padding)
    {
      try
      {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] dataToEncryptByte = ByteConverter.GetBytes(dataToEncrypt);
        byte[] encryptedData;
        using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
        {
          RSA.ImportParameters(rsaKeyInfo);
          encryptedData = RSA.Encrypt(dataToEncryptByte, padding);
        }
        return Convert.ToBase64String(encryptedData);
      }
      catch (CryptographicException e)
      {
        Console.WriteLine(e.Message);
        return null;
      }
    }

    public static string RSADecrypt(string dataToDecryptBase64, RSAParameters rsaKeyInfo, bool padding)
    {
      try
      {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] decryptedData;
        using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
        {
          var dataToDecrypt = Convert.FromBase64String(dataToDecryptBase64);
          RSA.ImportParameters(rsaKeyInfo);
          decryptedData = RSA.Decrypt(dataToDecrypt, padding);
        }
        return ByteConverter.GetString(decryptedData);
      }
      catch (CryptographicException e)
      {
        Console.WriteLine(e.ToString());
        return null;
      }
    }
  }
}
