using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using StACS.Core.Exceptions;

namespace StACS.System.StringExtensions
{
    public static class EncryptionDecryptionExtensions
    {
        /// <summary>
        ///     Encrypts the string source using the provided key
        /// </summary>
        /// <param name="source">The string to be encrypted</param>
        /// <param name="key">The key used to encrypt</param>
        /// <returns>The encrypted version of the string</returns>
        public static string Encrypt(this string source, string key)
        {
            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            if (!key.HasValue())
            {
                throw new ArgumentNullOrEmptyException("Cannot encrypt using an empty key. Please supply an encryption key.");
            }

            try
            {
                var cspp = new CspParameters { KeyContainerName = key };

                var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };

                var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(source), true);

                return BitConverter.ToString(bytes);
            }
            catch// (Exception ex)
            {
                // TODO: Make better Exception Handling
                throw;
            }
        }

        /// <summary>
        ///     Decrypts the string source using the provided key
        /// </summary>
        /// <param name="source">The string to be decrypted</param>
        /// <param name="key">The key used to decrypt</param>
        /// <returns>The decrypted version of the string</returns>
        public static string Decrypt(this string source, string key)
        {
            string result = null;

            if (!source.HasValue()) throw new SourceEmptyOrNullException(nameof(source));

            if (!key.HasValue())
            {
                throw new ArgumentNullOrEmptyException("Cannot decrypt using an empty key. Please supply a decryption key.");
            }

            try
            {
                var cspp = new CspParameters { KeyContainerName = key };

                var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };

                var decryptArray = source.Split(new[] { "-" }, StringSplitOptions.None);

                var decryptByteArray = decryptArray.Select(s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))).ToArray();

                var bytes = rsa.Decrypt(decryptByteArray, true);

                result = Encoding.UTF8.GetString(bytes);
            }
            catch// (Exception ex)
            {
                // TODO: Make better Exception Handling
                throw;
            }

            return result;
        }
    }
}