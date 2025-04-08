using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Usuario
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
        new Usuario{NombreUsuario = "Sofia", Contrasenia="1234"},

};
        public Usuario() { }

        public List<Usuario> Obtenerusuario()
        {
            return usuarios;
        }

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
