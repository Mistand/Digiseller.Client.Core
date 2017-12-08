using System.Security.Cryptography;
using System.Text;

namespace Digiseller.Client.Core.Helpers
{
    public static class Crypto
    {
        public static string SHA256(string str)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            var crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(str), 0, Encoding.UTF8.GetByteCount(str));
            foreach (var theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
