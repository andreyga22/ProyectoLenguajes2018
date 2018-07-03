using AdminBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminUI
{
    public partial class AdminClientes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLCliente cliente = new BLCliente();

            }
            managerCliente mc = new managerCliente();
            gvClientes.DataSource = mc.listaEnmascarada();
            gvClientes.DataBind();



        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text!="Codigo")
            {
                managerCliente mc = new managerCliente();
                BLCliente cliente = new BLCliente();
                cliente = mc.ConsultarCliente(txtBuscar.Text);
                txtNombre.Text = cliente.nombreUsuario;
                txtPriApe.Text = cliente.primerApellido;
                txtSegApe.Text = cliente.segundoApellido;
                txtEmail.Text = cliente.email;
                txtContrasena.Text =cliente.contrasena;
                txtTelefono.Text = cliente.telefono;
                txtrol.Text = cliente.rol;
                btnBorrar.Enabled = true;
                btnBorrar.Visible=true;

            }


        }

        protected void btnGuardarMod_Click(object sender, EventArgs e)
        {
        



        }

        protected void btnGuardarMod_Click1(object sender, EventArgs e)
        {
            BLCliente cliente = new BLCliente();
            string nombre = txtNombre.Text;
            string priape = txtPriApe.Text;
            string segape = txtSegApe.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string contra = txtContrasena.Text;
            string rol = txtrol.Text;

            if (txtBuscar.Text == "")
            {
                cliente = new BLCliente(nombre, priape, segape, 0, rol, telefono, email, contra, true);

            }
            else
            {
                int id =int.Parse(txtBuscar.Text);

                cliente = new BLCliente(nombre, priape, segape, id, rol, telefono, email, contra, true);
            }

            managerCliente mc = new managerCliente();
            mc.insertarOModificar(cliente);
            gvClientes.DataSource = mc.listaEnmascarada();
            gvClientes.DataBind();


        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            managerCliente mc = new managerCliente();
            mc.EliminarCliente(mc.ConsultarCliente(txtBuscar.Text));
            gvClientes.DataSource = mc.listaEnmascarada();
            gvClientes.DataBind();

        }
    }
}