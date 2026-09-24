using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AventuraRPG
{
    public class Jugador : Personaje
    {
        public int Pociones;

        public Jugador(string nombre)
            : base(nombre, 100, 20)
        {
            Pociones = 2;
        }

        public void Curarse()
        {
            if (Pociones > 0)
            {
                Vida += 30;

                if (Vida > 100)
                    Vida = 100;

                Pociones--;

                Console.WriteLine("Te curaste 30 puntos de vida.");
            }
            else
            {
                Console.WriteLine("No tienes pociones.");
            }
        }
    }
}
