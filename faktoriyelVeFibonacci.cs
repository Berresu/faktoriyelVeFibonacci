using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büüüüüü
{
    internal class Program
    {
        public static void faktoriyelVeFibonacci()
        {
            int i = 1;
            Console.Write("Faktöriyel Hesaplamak İçin Bir Sayı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Uzunluğu İçin Bir Sayı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayiA = 1;
            int sayiB = 1;
            int sayiC;
            int faktoriyel = 1;

            while(i <= sayi1){
                faktoriyel = faktoriyel * i;
                i++;
            }

            Console.WriteLine(faktoriyel+"!");

            for (int n = 1; n < sayi2; n++) {
                sayiC = sayiA + sayiB;
                sayiA = sayiB;
                sayiB = sayiC;

                Console.Write(sayiC + ", ");
            }
        }
        static void Main(string[] args)
        {
            faktoriyelVeFibonacci();
        }
    }
}
