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
                        Perdiste(numSecreto);
                        //Console.Write("Perdiste, el numero era el : " + numSecreto);
                        break;
                    }
                Console.Write("No adivinaste, segui intentando\n");
            }
                else
            {
                Ganaste();
                //Console.Write("Felicitaciones, ganaste!");
                break;
            }

                static void Ganaste()
                {
                    Console.WriteLine("Felicitaciones, ganaste!");
                }

                static void Perdiste(int num)
                {
                    Console.Write("Perdiste, el numero era el : " + num);
                }

            }
        }
    }
}
