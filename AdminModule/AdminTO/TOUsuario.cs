using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminTO
{
    public class TOUsuario
    {
        public String nombreUsuario { get; set; }
        public String primerApellido { get; set; }
        public String segundoApellido { get; set; }
        public String id { get; set; }
        public String rol { get; set; }
        public String email { get; set; }
        public String contrasena { get; set; }

        public TOUsuario()
        {

        }
        public TOUsuario(String nombreUsuario, String primerApellido, String segundoApellido, 
            String id, String rol, String email, String contrasena)
        {
            this.nombreUsuario = nombreUsuario;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.id = id;
            this.rol = rol;
            this.email = email;
            this.contrasena = contrasena;
        }

    }
}
