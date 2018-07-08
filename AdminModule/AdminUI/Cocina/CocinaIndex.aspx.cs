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
            traerLista();
            cargarCartas();
            if (!IsPostBack) {
                ViewState["listaPedidos"] = null;
            }
        }

        private void traerLista() {
            ManagerPedidos manager = new ManagerPedidos();
            listaPedidos = manager.listaPedidos();
        }

        private void retornar() {
            List<BLPedidos> nueva = new List<BLPedidos>();
            nueva.Add((BLPedidos)ViewState["listaPedidos"]);
            nueva.AddRange(listaPedidos);
            listaPedidos = nueva;
        }

        private void cargarCartas() {

            fila1.Text = "<div class=\"row align-items - center\">" +
              "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-"+estadoColor( listaPedidos[0]) +" mb-3\" style=\"max-width: 18rem;\">"+
                  "<div class=\"card-header\">Orden: " + listaPedidos[0].codigo + "</div>" +
                  "<div class=\"card-body\">"+
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[0].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>"+
                     "<a href = \"#\" class=\"btn btn-primary\">Entregar Pedido</a>"+
                  "</div>"+
                "</div>"+
            "</div>"+

            "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-" + estadoColor(listaPedidos[1]) + " mb-3\" style=\"max-width: 18rem;\">" +
                  "<div class=\"card-header\">Orden: " + listaPedidos[1].codigo + "</div>" +
                  "<div class=\"card-body\">" +
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[1].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>" +
                  "</div>" +
                "</div>" +
            "</div>" +

            "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-" + estadoColor(listaPedidos[2]) + " mb-3\" style=\"max-width: 18rem;\">" +
                  "<div class=\"card-header\">Orden: " + listaPedidos[2].codigo + "</div>" +
                  "<div class=\"card-body\">" +
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[2].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>" +
                  "</div>" +
                "</div>" +
            "</div>" +
            "</div>";

            fila2.Text = "<div class=\"row align-items - center\">" +
              "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-" + estadoColor(listaPedidos[3]) + " mb-3\" style=\"max-width: 18rem;\">" +
                  "<div class=\"card-header\">Orden: " + listaPedidos[3].codigo + "</div>" +
                  "<div class=\"card-body\">" +
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[3].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>" +
                  "</div>" +
                "</div>" +
            "</div>" +

            "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-" + estadoColor(listaPedidos[4]) + " mb-3\" style=\"max-width: 18rem;\">" +
                  "<div class=\"card-header\">Orden: " + listaPedidos[4].codigo + "</div>" +
                  "<div class=\"card-body\">" +
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[4].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>" +
                  "</div>" +
                "</div>" +
            "</div>" +

            "<div class=\"col-lg-4 align-self-center\">" +
                "<div class=\"card text-white bg-" + estadoColor(listaPedidos[5]) + " mb-3\" style=\"max-width: 18rem;\">" +
                  "<div class=\"card-header\">Orden: " + listaPedidos[5].codigo + "</div>" +
                  "<div class=\"card-body\">" +
                    "<h5 class=\"card-title\">Cliente: " + listaPedidos[5].email + "</h5>" +
                    "<p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card's content.</p>" +
                  "</div>" +
                "</div>" +
            "</div>" +

            "</div>";
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
    }
}