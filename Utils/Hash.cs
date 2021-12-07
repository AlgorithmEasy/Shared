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
    }
}