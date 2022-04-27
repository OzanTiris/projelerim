using System;

namespace toplam_carpım_fark_bölüm_hes
{
    class Program
    {
        static void Main(string[] args)
        {
            // değişken tanımlama yap

            int a, b, top, fark, carp;

            double ort, bol;

            // klavyeden giriş al

            Console.Write("1. sayıyı girin :");

            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("2. sayıyı girin :");

            b = Convert.ToInt16(Console.ReadLine());

            // işlemleri yap

            top = a + b;

            fark = a - b;

            carp = a * b;

            bol = a / b;

            ort = top / 2;

            // işlem sonuclarını ekrana yaz

            Console.WriteLine("Toplam :" + top);

            Console.WriteLine("Fark :" + fark);

            Console.WriteLine("Çarpım :" + carp);

            Console.WriteLine("Bölüm :" + bol);

            Console.WriteLine("Ortalama :" + ort);

            Console.ReadKey();

        }
    }
}
