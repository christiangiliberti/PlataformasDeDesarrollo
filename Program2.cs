using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, 
            num = 0;
            
            Console.WriteLine("Se deben ingresar 10 numeros, el ingreso se detendra si la suma de los numero supera los 50");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (sum >= 50)
                {
                break;
                }
            }

        }
    }
}
