using System.Security.Cryptography;
using System.Text;

namespace AlgorithmEasy.Shared.Utils
{
    public static class Hash
    {
        public static byte[] GetSha256(this string str)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
        }

        public static string GetSha256String(this string str)
        {
            var stringBuilder = new StringBuilder();
            foreach (var b in str.GetSha256())
                stringBuilder.Append(b.ToString("X2"));
            return stringBuilder.ToString();
        }
    }
}