using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;

namespace AdminUI {
    public partial class platos : System.Web.UI.Page {

        private string path = "~/img/";

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            try {

                ManejadorPlato manejador = new ManejadorPlato();
                int estado = estadoRb.SelectedIndex;
                Boolean estado2;
                if (estado == 0) {
                    estado2 = true;
                } else {
                    estado2 = false;
                }
                string name = fotoT.FileName;
                string url = path + fotoT.FileName;
                fotoT.PostedFile.SaveAs(path + fotoT.FileName);
                BLPlato plato = new BLPlato(nombreT.Text.Trim(), descripcionT.Text.Trim(), Convert.ToDouble(precioT.Text.Trim()), url, estado2);
                Boolean seInserto=  manejador.insertarPlato(plato);

            } catch (Exception ex) {
                throw ex;
            }
        }

        protected void estadoRb_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}