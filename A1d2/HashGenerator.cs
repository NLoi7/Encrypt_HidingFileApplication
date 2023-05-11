using System.Security.Cryptography;
using System.Text;

namespace A1d2
{
    static class HashGenerator
    {
        public static string GetHash(byte[] input)
        {
            using (SHA1Managed sha = new SHA1Managed()) // sử dụng hàm băm sha
            {
                var hash = sha.ComputeHash(input); //160bits
                var sb = new StringBuilder(hash.Length * 2); // tạo 1 builder có dung lượng là hash.length*2 

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2")); 
                }
                return sb.ToString();
            }
        }
    }
}
