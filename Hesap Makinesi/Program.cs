using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string Operatör;

            Bolme Bölme = new Bolme();
            Topla Toplama = new Topla();
            Cikar Çıkarma = new Cikar();
            Carp Çarpma = new Carp();

            Console.Write("1. Sayıyı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operatör Giriniz:");
            Operatör = Console.ReadLine();

            switch (Operatör)
            {
                case "+":
                    {
                        Toplama.Toplam(a, b);
                        break;
                    }
                case "-":
                    {
                        Çıkarma.Çıkarma(a, b);
                        break;
                    }
                case "*":
                    {
                        Çarpma.Çarpma(a, b);
                        break;
                    }
                case "/":
                    {
                        Bölme.Bölme(a, b);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Yanlış Bir Operatör Girdiniz");
                        break;
                    }
            }

            

            

            Console.ReadKey();
        }
    }
}
