using System;

namespace kalvyeden_girilen_sayının_faktoriyeli
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int sayi;
            int f = 1;
            Console.WriteLine("sayı giriniz:");
              sayi = Convert.ToInt32(Console.ReadLine());
           
            while (sayi>1)
            {
                f = f * sayi;
                sayi--;
            }
            Console.WriteLine(f);


        }
    }
}
