using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("El juego consiste en adivinar un numero del 1 al 20), \ntenes 3 chances para hacerlo");


            Random random = new Random();
            int numSecreto = random.Next(20)+1;
            int chance = 0;
            int num = 0;


            while (num != numSecreto && chance < 3)
            {
                num = int.Parse(Console.ReadLine());
                chance++;
                if (num != numSecreto) { 
                if (chance == 3)

                    {
                        Console.Write("Perdiste, el numero era el : " + numSecreto);
                        break;
                    }
                Console.Write("No adivinaste, segui intentando\n");
            }
                else
            {
                Console.Write("Felicitaciones, ganaste!");
                break;
            }


            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                IngreseElNumero("Ingrese el numero ", ref numero);

                if (numero == secreto) break;
            }
            string resultado;
            if (numero == secreto)
            {
                resultado = Ganaste();
            }
            else
            {
                resultado = Perdiste(secreto);
            }
            Console.WriteLine(resultado);
            }

             static int IngreseElNumero(string mensaje, ref int numero)
            {
            Console.WriteLine(mensaje);
            string valor = Console.ReadLine();
            return int.Parse(valor);
             }

            static string Ganaste()
            {
            string mensaje = "Ganaste";
            return mensaje;
             }
            static string Perdiste(int valor)
            {
            return "Perdiste el numero era " + valor;
            */

        }
    }
    }
}
