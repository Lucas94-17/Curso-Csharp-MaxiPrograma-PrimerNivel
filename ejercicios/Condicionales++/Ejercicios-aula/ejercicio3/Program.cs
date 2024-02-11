using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int cpu , ram,disco,importe;
            Console.WriteLine("\t i5(1) \t i7(2) \t i9(3)");
            Console.WriteLine("8 RAM(1) USD 800 USD 900 USD 1200");
            Console.WriteLine("16 RAM(2) USD 900 USD 1000 USD 1400");
            Console.WriteLine("32 RAM(3) USD 1000 USD 1400 USD 2000");
            
            Console.WriteLine("Ingrese el cpu que desea");
            cpu = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la ram que desea");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Si usted quiere expandir la memoria de 500 gb a 1TB , ingrese 1 de lo contrario 0");
            disco = int.Parse(Console.ReadLine());
            if (cpu == 1 && ram == 1 )
            {
                if (disco == 1)
                {
                    importe = 800 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 800;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 1 && ram == 2 )
            {
                if (disco == 1)
                {
                    importe = 900 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 900;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 1 && ram == 3 )
            {
                if (disco == 1)
                {
                    importe = 1000 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 1000;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 2 && ram == 1 )
            {
                if (disco == 1)
                {
                    importe = 900 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 900;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 2 && ram == 2 )
            {
                if (disco == 1)
                {
                    importe =  1000+ 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 1000;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 2 && ram == 3 )
            {
                if (disco == 1)
                {
                    importe = 1400 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 1400;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 3 && ram == 1 )
            {
                if (disco == 1)
                {
                    importe =  1200+ 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 1200;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 3 && ram == 2 )
            {
                if (disco == 1)
                {
                    importe = 1400 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 1400;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
            if (cpu == 3 && ram == 3 )
            {
                if (disco == 1)
                {
                    importe = 2000 + 300;
                    Console.WriteLine("El precio es : " + importe);
                }else{
                    importe = 2000;
                    Console.WriteLine("El precio es : " + importe);
                }
            }
        }
    }
}
