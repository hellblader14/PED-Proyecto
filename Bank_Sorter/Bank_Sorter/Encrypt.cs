using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Bank_Sorter
{
	public class Aes256Base64Encrypter
	{
		public string Encrypt(string plainText, string secretKey)
		{
			string encryptedPassword = null;
			using (MemoryStream outputStream = new MemoryStream())
			{
				RijndaelManaged algorithm = getAlgorithm(secretKey);
				using (CryptoStream cryptoStream = new CryptoStream(outputStream, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
				{
					byte[] inputBuffer = Encoding.Unicode.GetBytes(plainText);
					cryptoStream.Write(inputBuffer, 0, inputBuffer.Length);
					cryptoStream.FlushFinalBlock();
					encryptedPassword = Convert.ToBase64String(outputStream.ToArray());
				}
			}
			return encryptedPassword;
		}


		private RijndaelManaged getAlgorithm(string secretKey)
		{
			const string salt = "Arkantos";
			const int keySize = 256;

			Rfc2898DeriveBytes keyBuilder = new Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes(salt));
			RijndaelManaged algorithm = new RijndaelManaged();
			algorithm.KeySize = keySize;
			algorithm.IV = keyBuilder.GetBytes(System.Convert.ToInt32(algorithm.BlockSize / (double)8));
			algorithm.Key = keyBuilder.GetBytes(System.Convert.ToInt32(algorithm.KeySize / (double)8));
			algorithm.Padding = PaddingMode.PKCS7;
			return algorithm;
		}
	}
}
