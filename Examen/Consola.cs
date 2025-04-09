using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Consola
    {
        public Consola() { }

        public Consola(int iD, string nombre, DateTime fechadeRegistro, bool activo)
        {
            ID = iD;
            Nombre = nombre;
            FechadeRegistro = fechadeRegistro;
            Activo = activo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechadeRegistro { get; set; }
        public bool Activo { get; set; }

    }
}
