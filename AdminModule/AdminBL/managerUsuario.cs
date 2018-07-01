using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminTO;
using AdminDAO;
namespace AdminBL
{
    public class managerUsuario
    {

        public void EliminarUsuario(BLUsuario usuario)
        {
            new DAOUsuario().EliminarUsuario(convert(usuario));
        }

        public BLUsuario ConsultarUsuario(String id)
        {
            return convert(new DAOUsuario().ConsultarUsuario(id));
        }

        public void EditarUsuario(BLUsuario usuario)
        {
            new DAOUsuario().EditarUsuario(convert(usuario));
        }

        public void InsertarUsuario(BLUsuario usuario)
        {
            new DAOUsuario().InsertarUsuario(convert(usuario));
        }

        public List<BLUsuario> listaUsuario()
        {
            List<TOUsuario> listaTO = new DAOUsuario().listaUsuario();
            List<BLUsuario> listaBL = new List<BLUsuario>();

            for (int i = 0;i<listaTO.Count();i++)
            {
                listaBL.Add(convert(listaTO[i]));
            }

            return listaBL;
        }





        public TOUsuario convert(BLUsuario usuarioBL)
        {
            TOUsuario usuario = new TOUsuario();
            usuario.nombreUsuario = usuarioBL.nombreUsuario;
            usuario.primerApellido = usuarioBL.primerApellido;
            usuario.segundoApellido = usuarioBL.segundoApellido;
            usuario.id = usuarioBL.id;
            usuario.rol = usuarioBL.rol;
            usuario.email = usuarioBL.email;
            usuario.contrasena = usuarioBL.contrasena;
            return usuario;
        }

        public BLUsuario convert(TOUsuario usuarioTO)
        {
            BLUsuario usuario = new BLUsuario();
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
