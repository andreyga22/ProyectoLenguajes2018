using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AdminBL;
namespace AdminUI.Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        List<BLPlato> Platos();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json)]
        BLPlato PlatoBusqueda(String codigo);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        BLCliente ConsultarCliente(String email,String contraseña);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        void ingresarUsuario(String nombreUsuario, String primerApellido, String segundoApellido,
            String telefono, String email, String contrasena);
    }
}
