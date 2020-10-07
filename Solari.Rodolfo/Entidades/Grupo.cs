using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> Manada;
        private string nombre;
        private static EtipoManada tipo;

        public static EtipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }

        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }
        private Grupo(){
            Manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }


        public static bool operator ==(Grupo g, Mascota m)
        {
            bool respuesta = false;
            foreach (Mascota item in g.Manada)
            {
                if (m.Equals(item)) {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.Manada.Add(m);
            }
            else
            {
                Console.WriteLine("Ya esta "+ m.ToString() + " en el grupo ");
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.Manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No esta " + m.ToString() + " en el grupo ");
            }
            return g;
        }

        public static implicit operator string(Grupo g) {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Grupo: " + g.nombre + " - " + Grupo.tipo);
            str.AppendFormat("Integrantes ({0})\n",g.Manada.Count);
            foreach (Mascota item in g.Manada)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
        }

    }
}
