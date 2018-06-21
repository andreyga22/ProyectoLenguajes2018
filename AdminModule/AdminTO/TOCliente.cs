using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminTO
{
    public class TOCliente
    {
        public String nombreUsuario { get; set; }
        public String primerApellido { get; set; }
        public String segundoApellido { get; set; }
        public int id { get; set; }
        public String rol { get; set; }
        public String telefono { get; set; }

        public String email { get; set; }
        public String contrasena { get; set; }

        public TOCliente()
        {

        }
        public TOCliente(String nombreUsuario, String primerApellido, String segundoApellido,
            int id, String rol, String telefono, String email, String contrasena)
        {
            this.nombreUsuario = nombreUsuario;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.id = id;
            this.rol = rol;
            this.telefono = telefono;
            this.email = email;
            this.contrasena = contrasena;
        }

    }
}
