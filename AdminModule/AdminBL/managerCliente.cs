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

        public void EliminarUsuario(BLCliente usuario)
        {
            new DAOCLiente().EliminarUsuario(convert(usuario));
        }

        public BLCliente ConsultarUsuario(String id)
        {
            return convert(new DAOCLiente().ConsultarUsuario(id));
        }

        public void EditarUsuario(BLCliente usuario)
        {
            new DAOCLiente().EditarUsuario(convert(usuario));
        }

        public void InsertarUsuario(BLCliente usuario)
        {
            new DAOCLiente().InsertarUsuario(convert(usuario));
        }

        public List<BLCliente> listaUsuario()
        {
            List<TOCliente> listaTO = new DAOCLiente().listaUsuario();
            List<BLCliente> listaBL = new List<BLCliente>();

            for (int i = 0;i<listaTO.Count();i++)
            {
                listaBL.Add(convert(listaTO[i]));
            }

            return listaBL;
        }





        public TOCliente convert(BLCliente usuarioBL)
        {
            TOCliente usuario = new TOCliente();
            usuario.nombreUsuario = usuarioBL.nombreUsuario;
            usuario.primerApellido = usuarioBL.primerApellido;
            usuario.segundoApellido = usuarioBL.segundoApellido;
            usuario.id = usuarioBL.id;
            usuario.rol = usuarioBL.rol;
            usuario.email = usuarioBL.email;
            usuario.contrasena = usuarioBL.contrasena;
            return usuario;
        }

        public BLCliente convert(TOCliente usuarioTO)
        {
            BLCliente usuario = new BLCliente();
            usuario.nombreUsuario = usuarioTO.nombreUsuario;
            usuario.primerApellido = usuarioTO.primerApellido;
            usuario.segundoApellido = usuarioTO.segundoApellido;
            usuario.id = usuarioTO.id;
            usuario.rol = usuarioTO.rol;
            usuario.email = usuarioTO.email;
            usuario.contrasena = usuarioTO.contrasena;
            return usuario;
        }
    }
}
