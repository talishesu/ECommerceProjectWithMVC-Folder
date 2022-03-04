using System;
using System.Security.Cryptography;
using System.Text;

namespace Shop.Cryptolib
{
    public partial class Crypto
    {
        static string saltKey = "shop-security_key2022";


        public static string ToMd5(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }


            MD5 mixer = MD5.Create();


            value = $"{saltKey}{value}|{saltKey}";

            byte[] byteBuffer = Encoding.UTF8.GetBytes(value);

            byte[] computedBuffer = mixer.ComputeHash(byteBuffer);


            StringBuilder stringBuilder = new StringBuilder();

            foreach (var b in computedBuffer)
            {

                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }



        public static string ToSha1(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            SHA1 mixer = SHA1.Create();

            value = $"@{saltKey}_{value}-1";

            byte[] byteBuffer = Encoding.UTF8.GetBytes(value);
            byte[] computedBuffer = mixer.ComputeHash(byteBuffer);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var b in computedBuffer)
            {

                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
