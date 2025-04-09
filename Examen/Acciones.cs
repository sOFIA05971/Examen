using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Acciones
    {
        List<Nintendo> LNintendo = new List<Nintendo>
        {
            new Nintendo (102,"Joel",DateTime.Today,true,"Azul"),
            new Nintendo (203,"Liah",DateTime.Today,false,"Blanco"),
            new Nintendo (665,"Zara",DateTime.Today,false,"Blanco"),
            new Nintendo (285,"Erick",DateTime.Today,true,"Verde"),

        };
        Nintendo n = new Nintendo();

        public List<Nintendo> MostrarN()

        {
            return LNintendo;
        }

        public bool EliminarN(int ID)
        {
            try
            {
                var objetoeliminar = LNintendo.Find(x => x.ID == ID);
                if (objetoeliminar != null)
                {
                    LNintendo.Remove(objetoeliminar);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool AgregarN(int iD, string nombre, DateTime fechadeRegistro, bool activo, string colorInterfaz)
        {
            try
            {
                LNintendo.Add(new Nintendo(n.ID = iD, n.Nombre = nombre, n.FechadeRegistro = fechadeRegistro, n.Activo = activo, n.ColorInterfaz = colorInterfaz));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarN(int iD, string nombre, DateTime fechadeRegistro, bool activo, string colorInterfaz) 
        {
            try
            {
                var objetoActualizar = LNintendo.Find(x => x.ID == iD);
                if (objetoActualizar != null)
                {
                    objetoActualizar.Nombre = nombre;
                    objetoActualizar.FechadeRegistro = fechadeRegistro;
                    objetoActualizar.Activo = activo;
                    objetoActualizar.ColorInterfaz = colorInterfaz;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
    

