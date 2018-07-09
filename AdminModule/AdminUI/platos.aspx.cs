using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;

namespace AdminUI {
    public partial class platos : System.Web.UI.Page {

        private string url = "";

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            //try {

                ManejadorPlatos manejador = new ManejadorPlatos();
                int estado = estadoRb.SelectedIndex;
                Boolean estado2;
                if (estado == 0) {
                    estado2 = true;
                } else {
                    estado2 = false;
                }

                guardarFoto();

                //string name = fotoT.FileName;
                //fotoT.PostedFile.SaveAs(path + fotoT.FileName);
                BLPlato plato = new BLPlato(nombreT.Text.Trim(), descripcionT.Text.Trim(), Convert.ToDouble(precioT.Text.Trim()), "/img/" + fotoT.FileName.Trim(), estado2);
                Boolean seInserto=  manejador.insertarPlato(plato);

            //} catch (Exception ex) {
            //    throw ex;
            //}
        }


        private void guardarFoto() {

            Boolean fileOK = false;
            String path = Server.MapPath("~/img/");
            if (fotoT.HasFile) {
                String fileExtension =
                    System.IO.Path.GetExtension(fotoT.FileName).ToLower();
                String[] allowedExtensions =
                    {".gif", ".png", ".jpeg", ".jpg"};
                for (int i = 0; i < allowedExtensions.Length; i++) {
                    if (fileExtension == allowedExtensions[i]) {
                        fileOK = true;
                    }
                }
            }

            if (fileOK) {
                try {
                    fotoT.PostedFile.SaveAs(path
                        + fotoT.FileName);
                    url = path
                        + fotoT.FileName;
                    Label6.Text = "File uploaded!";
                } catch (Exception ex) {
                    Label6.Text = "File could not be uploaded.";
                }
            } else {
                Label6.Text = "Cannot accept files of this type.";
            }
        }

        protected void estadoRb_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            buscarTxt.Enabled = false;
            string cod = buscarTxt.Text.Trim();
            ManejadorPlatos manager = new ManejadorPlatos();
            BLPlato plato = manager.buscarPlato(Convert.ToInt32( cod));
            buscarTxt0.Text = plato.Nombre;
            buscarTxt1.Text = plato.Descripcion;
            buscarTxt2.Text = Convert.ToString( plato.Estado);
            buscarTxt3.Text = Convert.ToString(plato.Precio);
            //buscarTxt4.Text = Convert.ToString(plato.Codigo);
            Image1.ImageUrl = plato.Fotografia.Trim();
        }

        protected void btnModificar_Click(object sender, EventArgs e) {

        }

        protected void btnBorrar_Click(object sender, EventArgs e) {
            buscarTxt.Enabled = false;
            string cod = buscarTxt.Text.Trim();
            ManejadorPlatos manager = new ManejadorPlatos();
            Boolean sirvio = manager.borrarPlato(Convert.ToInt32(cod));
            if (sirvio) {
                Label6.Text = "Se borro";

            } else {
                Label6.Text = "No se borro";
            }
        }

        protected void btnLista_Click(object sender, EventArgs e) {
            ManejadorPlatos manejador = new ManejadorPlatos();
            List<BLPlato> lista = manejador.listaPlatos();
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }
    }
}