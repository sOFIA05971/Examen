using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Nintendo : Consola
    {
        public Nintendo() { }

        public Nintendo(int iD, string nombre, DateTime fechadeRegistro, bool activo, string colorInterfaz)
            : base(iD, nombre, fechadeRegistro, activo)
        {
            ColorInterfaz = colorInterfaz;
        }      

        public string ColorInterfaz { get; set; }
    }
 
}
