using System.Security.Cryptography;
using System.Text;

namespace Avataweb
{
    public static class AvataExtension
    {
        public static string ToAvata(this string email)
        {
            if(string.IsNullOrEmpty(email))
            return string.Empty;
            
            using var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(email);
            var hashBytes = md5.ComputeHash(inputBytes);
            //VAriavel transformada em BYTES

            var code = new StringBuilder();

            foreach(var b in hashBytes){
                    code.Append(b.ToString("X2"));
            }
            
            return $"https://www.gravatar.com/avatar/{code.ToString().ToLower()}";
            

        }

    }
}
