using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
using AdminUI;
namespace AdminUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String usuario = TextBox1.Text;
            String contra = TextBox2.Text;
            BLCliente cli = new managerCliente().ConsultarClienteConContraseña(usuario, contra);
            if (cli != null)
            {
                Session["usuarioLO"] = cli;

                if (cli.rol.Equals("Cocina"))
                {
                    Response.Redirect("CocinaIndex.aspx");
                }
                else if (cli.rol.Equals("Administrador"))
                {
                    Response.Redirect("adminIndex.aspx");
                }

            }
            else
            {
                Label3.Text = "El usuario no existe";
            }


                

         }
        
    }
}