using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoHashing
{
    internal class Program
    {
        static string saltKey = "9979198940c77d09758137a3feca3a86";
        static void Main(string[] args)
        {
            string hashMd5 = ToMd5("1");
            string hashSha1 = ToSha1("1");
            Console.WriteLine(hashMd5);
            Console.WriteLine(hashSha1);
            Console.ReadKey();

        }

        static string ToMd5(string value)
        {
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



        static string ToSha1(string value)
        {
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
