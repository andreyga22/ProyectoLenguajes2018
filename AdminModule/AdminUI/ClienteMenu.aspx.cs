using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;

namespace AdminUI
{
    public partial class ClienteMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            managerCliente mc = new managerCliente();
            GridView1.DataSource = mc.listaCliente();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BLCliente cliente = new BLCliente(txtNombre.Text, txtPri.Text, txtSeg.Text, -1, txtRol.Text, txtTelefono.Text, txtEmail.Text, txtContra.Text);
            managerCliente mc = new managerCliente();
            mc.InsertarCliente(cliente);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            managerCliente mc = new managerCliente();
            BLCliente cliente = new BLCliente(txtNombre.Text, txtPri.Text, txtSeg.Text, Convert.ToInt32(txtid.Text), txtRol.Text, txtTelefono.Text, txtEmail.Text, txtContra.Text);

            mc.EliminarCliente(cliente);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            managerCliente mc = new managerCliente();
            BLCliente cliente = new BLCliente(txtNombre.Text, txtPri.Text, txtSeg.Text, Convert.ToInt32(txtid.Text), txtRol.Text, txtTelefono.Text, txtEmail.Text, txtContra.Text);

            mc.EditarCliente(cliente);

        }
    }
}