using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero");
            int num;
            int numinv = 0;
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                while(num > 0)
                {
                    numinv = numinv * 10 + (num % 10);
                    num = num / 10;
                }
                Console.Write("El numero invertido es " + numinv);
            }
            else
            {
                Console.WriteLine("Ingrese un numero mayor a 0");
            }

        }

    }
}
