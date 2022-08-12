using System;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreglo_n = new string[10];
            string[] arreglo_a = new string[10];
            int[] arreglo_e = new int[10];
            string[] arreglo_s = new string[10];
            int cont;
            for(cont=0;cont<10;cont++)
            {
                Console.WriteLine("Ingrese el nombre: ");
                arreglo_n[cont] =Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el apellido: ");
                arreglo_a[cont] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese la edad: ");
                arreglo_e[cont] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sexo: ");
                arreglo_s[cont] = Convert.ToString(Console.ReadLine());

            }
            Console.Clear();
            for (cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Nombre-> "+arreglo_n[cont]); 
                Console.WriteLine("Apellido-> " + arreglo_a[cont]);
                Console.WriteLine("Edad-> " + arreglo_e[cont]);
                Console.WriteLine("Sexo-> " + arreglo_s[cont]);
                Console.WriteLine("----------------------");

            }
            Console.WriteLine("EDUTIN ACADEMY");
        }
    }
}
