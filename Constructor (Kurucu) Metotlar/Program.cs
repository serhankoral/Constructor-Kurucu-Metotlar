using System;

namespace Constructor__Kurucu__Metotlar
{
    internal class Program
    {
        /*
         * constructor yapıcılar class ile aynı isme sahip fonksiyondur 
         * aynı zamanda class oluşturulduğunda otomatik olarak çalışmasını sağlar
         * şimdi class oluşturup tanımlayalım
         * birden fazla oluşturulabilir
        */
        static void Main(string[] args)
        {
            isim test1 = new isim("serhan", "koral");
            isim test2 = new isim(15,"serhan", "koral");

        }
    }
    class isim
    {
        public isim(string ad, string soyad)
        {
            Console.WriteLine("Constructor tanımlandı ve değerler {0} ve {1} değerlerdir.", ad, soyad);
        }
        public isim(int yas, string ad, string soyad)
        {
            Console.WriteLine("Constructor tanımlandı ve değerler {0},{1} ve {2} değerlerdir.", ad, soyad, yas);

        }
    }
}
