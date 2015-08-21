using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace FOS_SaveEditor.Utility
{
	static class CryptoHandler
	{
		private const int keysize = 256;

		private const string INITVECTOR = "tu89geji340t89u2";
        private const string PASSPHRASE = "UGxheWVy";

		public static string EncryptSave(string plainText)
		{
			var initVectorBytes = Encoding.UTF8.GetBytes(INITVECTOR);
			var plainTextBytes = Encoding.UTF8.GetBytes(plainText);

			var keyBytes = new Rfc2898DeriveBytes(PASSPHRASE, initVectorBytes).GetBytes(keysize / 8);

			var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };

			var encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

			using (var memoryStream = new MemoryStream())
			using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
			{
				cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
				cryptoStream.FlushFinalBlock();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		public static string DecryptSave(string encryptedText)
		{
			var initVectorBytes = Encoding.UTF8.GetBytes(INITVECTOR);
			var encryptedTextBytes = Convert.FromBase64String(encryptedText);

			var keyBytes = new Rfc2898DeriveBytes(PASSPHRASE, initVectorBytes).GetBytes(keysize / 8);

			var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };

			var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

			using (var memoryStream = new MemoryStream())
			using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
			{
				cryptoStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length);
				cryptoStream.FlushFinalBlock();
				return Encoding.UTF8.GetString(memoryStream.ToArray());
			}
		}
	}
}
