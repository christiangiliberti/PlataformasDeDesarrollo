using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {


                List<int> listaN = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var nPar = listaN.Where(n => n % 2 == 0).OrderByDescending(n => n);
                foreach (var n in nPar)
                {
                    Console.WriteLine(n);
                }


            } } } }
            /*
            string[] nombres = { "Gabriel", "Facuendo", "Francisco", "Maria" };
            IEnumerable<string> empiezanConf = from nombre in nombres where nombre.StartsWith("F") select nombre;

            IEnumerable<string> empiezanConM = nombres.Where(i => i.StartsWith("M"));


            foreach (var item in empiezanConf)
            {
                Console.WriteLine(item);

            }

            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms bluid", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            IEnumerable<Actividad> pasados = eventos.Where(i =>i.Fecha < DateTime.Now).Select (i => i.Nombre).ToList;
            
            Func<int, string, bool> validarEdad = (edad,genero) => (edad > 18 && genero =="M" || (edad>19&&genero=="F";
            Func<int, string, bool> validarEdad2 = (edad, genero) =>
            {
                if (genero == "M")
                {
                    return edad > 18;
                }
                else
                {
                    return edad > 19;
                }

            };


            validarEdad(20,"");

            // Action no devuelve ningun valor 
            Action<int> imprimir = (valor) => Console.WriteLine(valor);

            Console.ReadLine();
        }

        public bool validarEdadFull(int edad)
        {
            return edad > 18;
        }
    }
}*/
