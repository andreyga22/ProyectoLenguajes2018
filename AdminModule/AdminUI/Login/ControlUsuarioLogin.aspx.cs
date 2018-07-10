using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
namespace AdminUI
{
    public partial class ControlUsuarioLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void cerrarSesion()
        {
            Session["usuarioLO"] = null;
        }

        public BLCliente user()
        {
            return (BLCliente)Session["usuarioLO"];
        }
        public Boolean verificaCliente()
        {
            if (user() == null || !user().rol.Equals("Cliente") || user().rol.Equals(""))
            {
                return true;
            }
            return false;
        }
        public Boolean verificaCocina()
        {
            if ((user() == null || !user().rol.Equals("Cocina")) || user().rol.Equals("")) {
                return true;
            }
            return false;
        }
        public Boolean verificaAdmin() {
            if (user() == null || !user().rol.Equals("Administrador") || user().rol.Equals(""))
            {
                return true;
        }
            return false;
        }



    }
}