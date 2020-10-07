using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }


        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return this.nombre + " - " + this.raza;
        }

        public static bool operator ==(Mascota m1, Mascota m2){
            return (m1.raza == m2.raza && m1.nombre == m2.nombre);
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
    }
}
