using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = rd.Next(1000), conInt = 0, num;
            do
            {
                Console.Write("Ingrese número");
                num = Convert.ToInt32(Console.ReadLine());
                conInt++;
                if (num > n) Console.WriteLine("El Numero es menor...");
                else if (num < n) Console.WriteLine("El Numero es mayor...");
            }
            while (num != n);
            Console.WriteLine("Felicitaciones adivinaste en {0} intentos", conInt);
            Console.ReadKey();

        }
    }
}
