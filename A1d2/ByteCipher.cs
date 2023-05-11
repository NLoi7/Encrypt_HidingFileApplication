// originally created by Craig Phillips (CraigTP)
// modified to work on array of bytes by Gottfried Prasetyadi
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace A1d2
{
    public static class ByteCipher
    {
      
        private const int Keysize = 256; // 32 bytes , độ dài khóa 256bit
       
        //số lần lặp cho tính năng tạo byte mật khẩu 
        private const int DerivationIterations = 500;

        // CBC mode encrypt 
        public static byte[] Encrypt(byte[] plainTextBytes, string passPhrase)
        {
            // tạo random salt và iv, được dùng cả mã hóa và giải mã  
            var saltStringBytes = Generate128BitsRandomBytes();
            var ivStringBytes = Generate128BitsRandomBytes();
            
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations)) // tạo số ngẫu nhiên dựa trên HMACSHa1
			//Khởi tạo một phiên bản mới của lớp Rfc2898DeriveBytes bằng cách sử dụng mật khẩu, salt và số lần lặp lại để tạo key.
			{
				var keyBytes = password.GetBytes(Keysize / 8);  // getkey : mã hóa một chuỗi thành byte 
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7; //padding vào file bằng PKCS7
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                // cái quan trọng !!!, đầu tiên nối salt dô trước sau đó tới nối tiếp iv, cuối cùng là ciphertext -> decrypt sẽ lấy từng cái 
                                var cipherTextBytes = saltStringBytes; // bỏ salt  vào trước
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray(); // tiếp đó nối vào là iv
                                // concat dùng để nối chuỗi 
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray(); // cuối cùng là nối ciphertext
                                //toarray() copy cái string sang mảng mới
                                memoryStream.Close();
                                cryptoStream.Close();
                                return cipherTextBytes;  
                            }
                        }
                    }
                }
            }
        }

        public static byte[] Decrypt(byte[] cipherTextBytesWithSaltAndIv, string passPhrase)
        {
            // đầu tiên lấy salt
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 16).ToArray(); //16
            // take trích xuất chuỗi keysize/16 phần tử đầu tiên 
            
            //tiếp theo lấy iv
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 16).Take(Keysize / 16).ToArray();
            // skip bỏ qua keysize/16 phần tử đầu tiên và trả về các phần từ còn lại sau khi bỏ 
            
            //cuối cùng là lấy cipher 
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 16) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 16) * 2)).ToArray();

            // các bước trên là lấy từng thành phần , đầu tiên lấy salt, iv cuối cùng là cipher 
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations)) //tạo key ban đầu khi đã có salt và passphare
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged()) // AES
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                               
                                return plainTextBytes.SubArray(0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate128BitsRandomBytes()
        {
            var randomBytes = new byte[16]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider()) // random số
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
