using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
using System.Data;

namespace AdminUI {
    public partial class adminPlatos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
                ManejadorPlatos manejador = new ManejadorPlatos();
                List<BLPlato> lista = manejador.listaPlatos();
                gvPlatos.DataSource = lista;
                gvPlatos.DataBind();
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            string codigo = txtBuscar.Text.Trim();
            txtCod.Enabled = false;
            ManejadorPlatos manejador = new ManejadorPlatos();
            BLPlato plato = manejador.buscarPlato(Convert.ToInt32( codigo));
            txtCod.Text = Convert.ToString(plato.Codigo);
            txtDes.Text = plato.Descripcion;
            txtNom.Text = plato.Nombre;
            txtPre.Text = Convert.ToString(plato.Precio);
            rbEstado.SelectedValue = plato.Estado + "";
            Image2.ImageUrl = plato.Fotografia.Trim();
        }
    }
}