using System;


    class MevsimBulucu  
    {  
    enum Mevsim { Ilkbahar,Yaz,Sonbahar,Kis}
        static void Main()
        {
        Console.Write("1-12 arasında bir sayı giriniz! :");
        int ay = int.Parse(Console.ReadLine());
        Mevsim mevsim;
        if (ay >=1 && ay <=3) mevsim = Mevsim.Kis;
        else if (ay >=4 && ay <=6 ) mevsim = Mevsim.Ilkbahar;
        else if (ay >=7 && ay <= 9) mevsim = Mevsim.Yaz;
        else mevsim = Mevsim.Sonbahar;
        Console.WriteLine("Mevsim: "+mevsim);  
        }
    }

