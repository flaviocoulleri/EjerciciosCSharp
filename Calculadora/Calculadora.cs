using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, operacion;
            dynamic resu;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion que desea realizar:\n1)Suma 2)Resta 3)Multiplicacion 4)Division");
            operacion = Convert.ToDouble(Console.ReadLine());
            
            switch(operacion)
            { case 1:
                    resu = num1 + num2;
                    Console.WriteLine("El resultado es: "+resu);
                    break;
                case 2:
                    resu = num1 - num2;
                    Console.WriteLine("El resultado es: " + resu);
                    break;
                case 3:
                    resu = num1 * num2;
                    Console.WriteLine("El resultado es: " + resu);
                    break;
                case 4:
                    resu = num1 / num2;
                    Console.WriteLine("El resultado es: " + resu);
                    break;
            }
            Console.ReadKey();
        }   
    }
}
