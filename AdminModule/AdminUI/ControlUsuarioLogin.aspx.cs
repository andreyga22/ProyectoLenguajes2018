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

        public BLCliente user()
        {
            return (BLCliente)Session["usuarioLO"];
        }
        public void verificaCliente()
        {
            if (!user().rol.Equals("Cliente"))
            {
                Response.Redirect("login.aspx");
            }
        }
        public void verificaCocina()
        {
            if (!user().rol.Equals("Cocina"))
            {
                Response.Redirect("login.aspx");
            }
        }
        public void verificaAdmin()
        {
            if (!user().rol.Equals("Administrador"))
            {
                Response.Redirect("login.aspx");
            }
        }



    }
}