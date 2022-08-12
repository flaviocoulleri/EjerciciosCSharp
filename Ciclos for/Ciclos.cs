using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic suma=0, resta=0, multiplicacion=1, promedio=0;
            double num;
            int cont;
            
            for(cont=0;cont<10;cont++)
            { Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToDouble(Console.ReadLine());
                suma += num;
                resta -= num;
                multiplicacion *= num;
            }
            promedio = suma / 10;
            Console.WriteLine("La suma total es: "+suma);
            Console.WriteLine("La resta total es: " +resta);
            Console.WriteLine("La multiplicacion total es: " +multiplicacion);
            Console.WriteLine("El promedio total es: " +promedio);
            Console.ReadKey();
        }
    }
}
