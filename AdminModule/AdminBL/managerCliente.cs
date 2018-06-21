using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminTO;
using AdminDAO;
namespace AdminBL
{
    public class managerCliente
    {

        public void EliminarCliente(BLCliente cliente)
        {
            new DAOCLiente().EliminarCliente(convert(cliente));
        }

        public BLCliente ConsultarCliente(String id)
        {
            return convert(new DAOCLiente().ConsultarCliente(id));
        }

        public void EditarCliente(BLCliente cliente)
        {
            new DAOCLiente().EditarCliente(convert(cliente));
        }

        public void InsertarCliente(BLCliente cliente)
        {
            new DAOCLiente().InsertarCliente(convert(cliente));
        }

        public List<BLCliente> listaCliente()
        {
            List<TOCliente> listaTO = new DAOCLiente().listaCliente();
            List<BLCliente> listaBL = new List<BLCliente>();

            for (int i = 0;i<listaTO.Count();i++)
            {
                listaBL.Add(convert(listaTO[i]));
            }

            return listaBL;
        }





        public TOCliente convert(BLCliente clienteBL)
        {
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

        public BLCliente convert(TOCliente ClienteTO)
        {
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
