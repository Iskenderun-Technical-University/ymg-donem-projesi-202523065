using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ARAÇ_KİRALAMA_OTOMASYON
{
    internal class sifreleme
    {
        public static string MD5SİFRELE(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());






            return sb.ToString();

        }
        public static string SHA256Sifrele(string sifrelenecekMetin)
        {

            SHA256 sha256Hash = SHA256.Create();
            // byte dizi[] = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifrelenecekMetin));
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            dizi = sha256Hash.ComputeHash(dizi);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in dizi)
                stringBuilder.Append(item.ToString("x2").ToLower());


            return stringBuilder.ToString();



        }
    }
}
