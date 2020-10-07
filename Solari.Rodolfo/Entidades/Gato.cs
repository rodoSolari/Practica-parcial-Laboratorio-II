using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {

        public Gato(string nombre,string raza) : base(nombre, raza)
        {

        }
        protected override string Ficha()
        {
            return "Gato - " + base.DatosCompletos(); 
        }

        public override string ToString() {
            return this.Ficha();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((Mascota)g1 == (Mascota)g2);
        }


        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }


        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Gato)
            {
                rta = this == (Gato)obj;
            }
            return rta;
        }
    }
}
