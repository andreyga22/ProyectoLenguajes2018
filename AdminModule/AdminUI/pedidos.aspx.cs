using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
namespace AdminUI
{
    public partial class pedidos : System.Web.UI.Page
    {
        BLPedidos pedido = new BLPedidos();

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["pedido"] = new BLPedidos();
            reset();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            pedido = new BLPedidos();
            pedido.email = TextBox2.Text;
            pedido.estado = TextBox3.Text;
            pedido.fecha = DateTime.Now;
            new ManagerPedidos().InsertarPedidos(pedido);
            reset();
        }

        public void reset()
        {
            GridView1.DataSource = new ManagerPedidos().listaPedidos();
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String buscado = TextBox4.Text;
            pedido = new ManagerPedidos().ConsultarPedidos(buscado);
            TextBox2.Text = pedido.email ;
            TextBox3.Text = pedido.estado;
            Label6.Text = pedido.codigo+"";
            Label7.Text = pedido.fecha.ToString();
            reset();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            pedido.codigo = int.Parse(Label6.Text);
            pedido.email = TextBox2.Text;
            pedido.estado = TextBox3.Text;
            new ManagerPedidos().EditarPedidos(pedido);
            reset();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            pedido.codigo = int.Parse(Label6.Text);
            new ManagerPedidos().EliminarPedidos(pedido);
            reset();
        }
    }
}