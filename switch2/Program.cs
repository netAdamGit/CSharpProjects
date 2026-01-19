using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace switch2
{
    internal class Program
    {
        
        static void Main()
        {
            Console.Write("Bir gün sayısı gir (1-7) :");
            string  secim=Console.ReadLine();
            if (int.TryParse(secim, out int gunNo))
            {
                switch (gunNo)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;
                    default:
                        Console.WriteLine("Geçersiz gün numarası! Lütfen 1-7 arasında bir sayı giriniz.");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece sayı giriniz.");
            }



        }
    }
}
