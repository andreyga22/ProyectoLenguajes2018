using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL
{
   public class BLCliente
    {
        public String nombreUsuario { get; set; }
        public String primerApellido { get; set; }
        public String segundoApellido { get; set; }
        public int id { get; set; }
        public String rol { get; set; }
        public String telefono { get; set; }

        public String email { get; set; }
        public String contrasena { get; set; }

        public BLCliente()
        {

        }
        public BLCliente(String nombreUsuario, String primerApellido, String segundoApellido,
            int id, String rol,String telefono, String email, String contrasena)
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
