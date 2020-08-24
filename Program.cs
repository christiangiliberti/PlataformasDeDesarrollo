 using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            string mensaje;
            Console.WriteLine("Escribe el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2){
                mensaje = "El primer numero es mayor o igual que el segundo";
                
            }else{
                mensaje = "El segundo numero es mayor que el primero";
            }
            Console.WriteLine(mensaje);
            Console.ReadLine ();

        }
    }
}
