using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;

namespace AdminUI.Cocina {
    public partial class CocinaIndex : System.Web.UI.Page {
        private List<BLPedidos> listaPedidos = new List<BLPedidos>();
        protected void Page_Load(object sender, EventArgs e) {
            if (new ControlUsuarioLogin().verificaCocina() == true)
            {
                Response.Redirect("~/Login/login.aspx");
            }
            traerLista();
            if (listaPedidos.Count == 0) {
                btnEntregar.Visible = false;
            } else {
                btnEntregar.Visible = true;
            }
            cargarCartas();
            if (!IsPostBack) {
                ViewState["listaPedidos"] = null;
            }
        }

        private void traerLista() {
            ManagerPedidos manager = new ManagerPedidos();
            listaPedidos = manager.listaPedidosCocina();
        }

        private void retornar() {
            List<BLPedidos> nueva = new List<BLPedidos>();
            nueva.Add((BLPedidos)ViewState["listaPedidos"]);
            nueva.AddRange(listaPedidos);
            listaPedidos = nueva;
        }

        private void cargarCartas() {
            fila1.Text = "";
            for (int i = 0; i < 6; i++) {
                if (i < listaPedidos.Count) {
                    if (i == 0 || i == 3) {
                        fila1.Text = fila1.Text + "<div class=\"row align-items - center\">";
                    }
                    fila1.Text = fila1.Text + "<div class=\"col-lg-4 align-self-center\">" +
                    "<div class=\"card text-white bg-" + estadoColor(listaPedidos[i]) + " mb-3\" style=\"max-width: 18rem;\">" +
                      "<div class=\"card-header\">Orden: " + listaPedidos[i].codigo + "</div>" +
                      "<div class=\"card-body\">" +
                        "<h5 class=\"card-title\">Cliente: " + listaPedidos[i].email + "</h5>" +
                        "<p class=\"card-text\">" + new ManagerPedidos().pedidoDetalle(listaPedidos[i].detalles) + "</p>" +
                         "</div>" + 
                         "</div>" +
                    "</div>";
                    if (i == 2 || i == 5) {
                        fila1.Text = fila1.Text + "</div>";
                    }
                }
            }

            if (listaPedidos.Count > 6) {
                lblRestantes.Text = listaPedidos.Count - 6 + " restantes en cola";
            } else {
                lblRestantes.Text = "No hay pedidos en la lista";
            }
        }

        private String estadoColor(BLPedidos pedido) {
            if (pedido.estado.Equals("A Tiempo")) {
                return "success";
            } else {
                if (pedido.estado.Equals("Sobre Tiempo")) {
                    return "warning";
                } else {
                    return "danger";
                }
            }
        }

        protected void btnEntregar_Click(object sender, EventArgs e) {
            ViewState["listaPedidos"] = listaPedidos[0];
            listaPedidos[0].estado = "Entregado";
            new ManagerPedidos().EditarPedidos(listaPedidos[0]);
            listaPedidos.Remove(listaPedidos[0]);
            Response.Redirect("~/Cocina/CocinaIndex.aspx");
        }
    }
}