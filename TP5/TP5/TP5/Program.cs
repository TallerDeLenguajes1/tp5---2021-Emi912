using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            Ejercicio2(); 

        }

        private static void Ejercicio2()
        {   
            int a;
            int b;
            int operador;
            int aux = 0;
            do
            {
                Console.WriteLine("Escriba el primer numero");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el segundo numero");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Eliga la operacion que quiere realizar 1- Dividir, 2-Suma, 3-Multiplicar, 4- Restar ");
                operador = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {
                    case 1:
                        Console.WriteLine("El resultado es " + a / b);
                        break;
                    case 2:
                        Console.WriteLine($"El resultado de la suma es {a+b} " );
                        break;
                    case 3:
                        Console.WriteLine("El resultado del producto es " + a * b);
                        break;
                    case 4:
                        Console.WriteLine($"El resultado de la resta es {a - b}");
                        break;
                }

                Console.WriteLine("Quiere realizar otro calculo? 1- Si, 2-No");
                aux = Convert.ToInt32(Console.ReadLine());
            } while (aux == 1);
           

        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un numero entero");
            int num;
            int numinv = 0;
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                while (num > 0)
                {
                    numinv = numinv * 10 + (num % 10);
                    num = num / 10;
                }
                Console.Write("El numero invertido es " + numinv);
            }
            else
            {
                Console.WriteLine("No se puede invertir ese numero");
            }
        }
    }
}
