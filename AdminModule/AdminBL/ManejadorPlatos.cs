using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL {
    public class ManejadorPlatos {
        public Boolean insertarPlato(BLPlato plato) {
            try {

            } catch (Exception ex) {
                throw ex;
            }


        }



        public TO convert(BLCliente clienteBL) {
            TOCliente Cliente = new TOCliente();
            Cliente.nombreUsuario = clienteBL.nombreUsuario;
            Cliente.primerApellido = clienteBL.primerApellido;
            Cliente.segundoApellido = clienteBL.segundoApellido;
            Cliente.telefono = clienteBL.telefono;
            Cliente.id = clienteBL.id;
            Cliente.rol = clienteBL.rol;
            Cliente.email = clienteBL.email;
            Cliente.contrasena = clienteBL.contrasena;
            return Cliente;
        }

        public BLCliente convert(TOCliente ClienteTO) {
            BLCliente Cliente = new BLCliente();
            Cliente.nombreUsuario = ClienteTO.nombreUsuario;
            Cliente.primerApellido = ClienteTO.primerApellido;
            Cliente.segundoApellido = ClienteTO.segundoApellido;
            Cliente.telefono = ClienteTO.telefono;
            Cliente.id = ClienteTO.id;
            Cliente.rol = ClienteTO.rol;
            Cliente.email = ClienteTO.email;
            Cliente.contrasena = ClienteTO.contrasena;
            return Cliente;
        }
    }
}
