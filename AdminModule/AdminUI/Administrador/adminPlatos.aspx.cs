using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
using System.Data;
using System.IO;

namespace AdminUI {

    public partial class adminPlatos : System.Web.UI.Page {
        private string url = "";
        protected void Page_Load(object sender, EventArgs e) {
            new ControlUsuarioLogin().verificaAdmin();
            btnBorrar.Enabled = false;
            cargarGrid();

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
            string loca = plato.Fotografia.Trim();
            Image2.ImageUrl = loca;
            ViewState["FotoVieja"] = loca;
            btnBorrar.Enabled = true;
        }

        private void borrarFoto(string path) {
            var filePath = Server.MapPath(path);
            if (File.Exists(filePath)) {
                File.Delete(filePath);
            }
        }

        protected void btnGuardarMod_Click(object sender, EventArgs e) {
            BLPlato plato = new BLPlato();
            ManejadorPlatos manejador = new ManejadorPlatos();

            if (txtCod.Text.Trim().Equals("")) {
                //guardar
                plato.Nombre = txtNom.Text.Trim();
                plato.Descripcion = txtDes.Text.Trim();
                plato.Precio = Convert.ToInt32( txtPre.Text.Trim());
                guardarFoto();
                plato.Fotografia = "~/img/" + Foto.FileName.Trim();
                plato.Estado = Convert.ToBoolean(rbEstado.SelectedValue);
                manejador.insertarPlato(plato);
            } else {

                int estado = rbEstado.SelectedIndex;
                Boolean estado2;
                if (estado == 0) {
                    estado2 = true;
                } else {
                    estado2 = false;
                }
                if (Foto.HasFile) {
                    guardarFoto();
                    plato = new BLPlato(txtNom.Text.Trim(), txtDes.Text.Trim(), Convert.ToDouble(txtPre.Text.Trim()), "~/img/" + Foto.FileName.Trim(), Convert.ToInt32( txtCod.Text.Trim()),estado2);
                     manejador.actualizarPlato(plato);
                    borrarFoto(Convert.ToString( ViewState["FotoVieja"]));
                } else {
                    plato = new BLPlato(txtNom.Text.Trim(), txtDes.Text.Trim(), Convert.ToDouble(txtPre.Text.Trim()), Image2.ImageUrl, Convert.ToInt32(txtCod.Text.Trim()), estado2);
                    manejador.actualizarPlato(plato);
                }
        }
            btnBorrar.Enabled = false;
            borrarCampos();
            cargarGrid();
        }



        private void guardarFoto() {

            Boolean fileOK = false;
            String path = Server.MapPath("~/img/");
            if (Foto.HasFile) {
                String fileExtension =
                    System.IO.Path.GetExtension(Foto.FileName).ToLower();
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
                    Foto.PostedFile.SaveAs(path
                        + Foto.FileName);
                    url = path
                        + Foto.FileName;
                    Response.Write("<script>alert('Archivo Subido')</script>");
                } catch (Exception ex) {
                    Response.Write("<script>alert('File could not be uploaded.')</script>");
                }
            } else {
                Response.Write("<script>alert('Cannot accept files of this type.')</script>");
            }
        }

        private void cargarGrid() {
            ManejadorPlatos manejador = new ManejadorPlatos();
            List<BLPlato> lista = manejador.listaPlatos();
            gvPlatos.DataSource = lista;
            gvPlatos.DataBind();
        }

        protected void btnBorrar_Click(object sender, EventArgs e) {
            
            string cod = txtCod.Text.Trim();
            ManejadorPlatos manager = new ManejadorPlatos();
            Boolean sirvio = manager.borrarPlato(Convert.ToInt32(cod));
            if (sirvio) {
                Response.Write("<script>alert('Borrado')</script>");
            } else {
                Response.Write("<script>alert('No se pudo borrar')</script>");
            }
            borrarFoto(Convert.ToString(ViewState["FotoVieja"]));
            cargarGrid();
            borrarCampos();
        }









        private void borrarCampos() {
            txtCod.Text = "";
            txtDes.Text = "";
            txtNom.Text = "";
            txtPre.Text = "";
            txtBuscar.Text = "";
            Foto = null;
            Image2.ImageUrl = null;
        }
    }
}