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
        public BLCliente ConsultarClienteId(String id)
        {
            return convert(new DAOCLiente().ConsultarClienteId(id));
        }

        public BLCliente ConsultarClienteConContraseña(String id,String contra)
        {
            BLCliente cli = convert(new DAOCLiente().ConsultarCliente(id));
            if (cli.contrasena.Equals(contra))
            {
                return cli;
            }

            return null;
        }

        public void EditarCliente(BLCliente cliente)
        {
            new DAOCLiente().EditarCliente(convert(cliente));
        }

        public void InsertarCliente(BLCliente cliente)
        {
            new DAOCLiente().InsertarCliente(convert(cliente));
        }
        public void insertarOModificar(BLCliente cliente) {
            if (cliente.id==0)
            {
                InsertarCliente(cliente);
            }
            else
            {
                EditarCliente(cliente);
            }
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

        public List<BLCliente> listaEnmascarada()
        {
            List<BLCliente> lista = listaCliente();
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].contrasena = enmascarar(listaCliente()[i].contrasena);  

            }
            return lista; 

        }

        public String enmascarar(String clave) {
            String mascara = "";
            for (int i = 0; i < clave.Length; i++)
            {
                mascara += "*";
            }
            return mascara;
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
            Cliente.estado = clienteBL.estado;
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
            Cliente.estado = ClienteTO.estado;
            return Cliente;
        }
    }
}
