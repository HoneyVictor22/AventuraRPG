using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AventuraRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LA CUEVA OSCURA ===");
            Console.WriteLine();

            Console.Write("Escribe el nombre de tu heroe: ");
            string nombre = Console.ReadLine();

            Jugador jugador = new Jugador(nombre);
            Enemigo enemigo = new Enemigo("Goblin", 60, 15);

            Console.WriteLine();
            Console.WriteLine("¡" + jugador.Nombre + " entra en la cueva!");
            Console.WriteLine("¡Un Goblin aparece!");
            Console.WriteLine();

            while (jugador.Vida > 0 && enemigo.Vida > 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(jugador.Nombre + " | Vida: " + jugador.Vida);
                Console.WriteLine("Goblin | Vida: " + enemigo.Vida);
                Console.WriteLine();
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Curarse");
                Console.Write("Elige: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    jugador.Atacar(enemigo);
                }
                else if (opcion == "2")
                {
                    jugador.Curarse();
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                    continue;
                }

                if (enemigo.Vida > 0)
                {
                    enemigo.Atacar(jugador);
                }

                Console.WriteLine();
            }

            if (jugador.Vida > 0)
            {
                Console.WriteLine("¡GANASTE!");
                Console.WriteLine("Encontraste el tesoro.");
            }
            else
            {
                Console.WriteLine("Has sido derrotado...");
            }

            Console.ReadKey();
        }
    }
}