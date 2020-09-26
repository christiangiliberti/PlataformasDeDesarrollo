using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehiculo miauto = new Auto();
            Auto otroauto = new Auto();
            Vehiculo camion = new Camion();

            miauto.Marca = "Honda";
            miauto.Marca = "Civic";
            miauto.Motor = new CuatroCilindros();
            if(camion is Auto){
                ((Auto)camion).Puertas = 10;
            }
            

        }
    }
}
