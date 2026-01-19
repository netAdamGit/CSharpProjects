using System;

namespace EnumOrnek
{
    // Enum tanımı
    public enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Enum kullanım örneği
            Gunler bugun = Gunler.Cuma;

            Console.WriteLine($"Bugün: {bugun}");

            // Switch-case ile kullanım
            switch (bugun)
            {
                case Gunler.Pazartesi:
                    Console.WriteLine("Haftanın ilk günü, enerjiyle başla!");
                    break;
                case Gunler.Cuma:
                    Console.WriteLine("Hafta sonu yaklaşıyor, biraz daha sabır!");
                    break;
                case Gunler.Pazar:
                    Console.WriteLine("Dinlenme günü, yeni haftaya hazırlan.");
                    break;
                default:
                    Console.WriteLine("Normal bir gün.");
                    break;
            }
        }
    }
}

