using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AventuraRPG
{
    public class Personaje
    {
        public string Nombre;
        public int Vida;
        public int Ataque;

        public Personaje(string nombre, int vida, int ataque)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
        }

        public virtual void Atacar(Personaje enemigo)
        {
            enemigo.Vida -= Ataque;

            Console.WriteLine(Nombre + " ataca y causa " + Ataque + " de daño.");
        }
    }
}