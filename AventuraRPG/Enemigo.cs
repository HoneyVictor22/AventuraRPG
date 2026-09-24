using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AventuraRPG
{
    public class Enemigo : Personaje
    {
        public Enemigo(string nombre, int vida, int ataque)
            : base(nombre, vida, ataque)
        {
        }
    }
}