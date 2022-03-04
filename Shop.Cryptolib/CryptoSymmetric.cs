using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Cryptolib
{
    public partial class Crypto
    {
        public static string Encrypt(string value,string symmetricKey) 
        {
            if(string.IsNullOrEmpty(value))
                return "";

            if (string.IsNullOrEmpty(symmetricKey))
                return "";



            var mixer = new TripleDESCryptoServiceProvider();


            var md5 = MD5.Create();



            var byteBuffer = Encoding.UTF8.GetBytes(symmetricKey);
            var computedBuffer = md5.ComputeHash(byteBuffer);


            mixer.Mode = CipherMode.ECB;
            mixer.Padding = PaddingMode.PKCS7;


            byte[] valueBuffer = Encoding.UTF8.GetBytes(value);

            ICryptoTransform transform = mixer.CreateEncryptor(computedBuffer, computedBuffer);
            
            

            using(MemoryStream ms = new MemoryStream())
            using(CryptoStream cs = new CryptoStream(ms,transform,CryptoStreamMode.Write))
            {
                cs.Write(valueBuffer, 0, valueBuffer.Length);
                cs.FlushFinalBlock();

                ms.Position = 0;

                byte[] chipperBuffer = new byte[ms.Length];

                ms.Read(chipperBuffer, 0, chipperBuffer.Length);



                string result = Convert.ToBase64String(chipperBuffer);

                return result;
            }

                
        }

        public static string Decrypt(string value, string symmetricKey)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            if (string.IsNullOrEmpty(symmetricKey))
                return "";



            var mixer = new TripleDESCryptoServiceProvider();


            var md5 = MD5.Create();



            var byteBuffer = Encoding.UTF8.GetBytes(symmetricKey);
            var computedBuffer = md5.ComputeHash(byteBuffer);


            mixer.Mode = CipherMode.ECB;
            mixer.Padding = PaddingMode.PKCS7;


            byte[] valueBuffer = Convert.FromBase64String(value);

            ICryptoTransform transform = mixer.CreateDecryptor(computedBuffer, computedBuffer);



            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
            {
                cs.Write(valueBuffer, 0, valueBuffer.Length);
                cs.FlushFinalBlock();

                ms.Position = 0;

                byte[] chipperBuffer = new byte[ms.Length];

                ms.Read(chipperBuffer, 0, chipperBuffer.Length);



                string result = Encoding.UTF8.GetString(chipperBuffer);

                return result;
            }


        }
    }
}
