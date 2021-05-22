using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();

        }

        private static void Ejercicio4()
        {
            String Cadena;
            String Cadena2;
            Console.Write("Escriba una cadena por favor!!!\n");
            Cadena = Console.ReadLine();
            //Console.Write("El tamaño de la cadena que escribiste es " + Cadena.Length + "\n");
            //Console.Write("Escriba otra cadena para concatenarla con la primera\n");
            //Cadena2 = (Console.ReadLine());
            //Console.Write("La cadena resultante es " + string.Concat(Cadena, Cadena2));
            //Console.Write("Una parte de tu cadena es " + Cadena.Substring(2,4) + "\n");
            //foreach(char c in Cadena)
            //{
            //    Console.WriteLine(c);

            //}
            int aux;
            aux = Cadena.IndexOf("hola");
            if(aux == -1)
            {
                Console.WriteLine("No se Encontro la palabra");
            }
            else
            {
                Console.WriteLine("Se Encontro la palabra");

            }




        }

        private static void Ejercicio3()
        {
            double num;
            int a;
            int b;
            Console.WriteLine("Escriba un numero para calcular");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El valor absoluto del numero que ingresaste es {Math.Abs(num)}");
            Console.WriteLine($"El cuadrado del numero que ingresaste es {Math.Pow(num, 2)}");
            Console.WriteLine($"La raiz del numero que ingresaste es {Math.Sqrt(num)}");
            Console.WriteLine($"El Seno del numero que ingresaste es {Math.Sin(num)}");
            Console.WriteLine($"El Coseno del numero que ingresaste es {Math.Cos(num)}");
            Console.WriteLine($"El numero redondeado que ingresaste es {Math.Round(num)}");

            Console.WriteLine("Escriba dos numeros ahora para compararlos");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El mas grande entre esos dos numeros es {Math.Max(a, b)}");
            Console.WriteLine($"El mas chico entre esos dos numeros es {Math.Min(a, b)}");





        }

        private static void Ejercicio2()
        {   
            float a;
            float b;
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
