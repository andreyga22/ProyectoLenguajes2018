using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
namespace AdminUI
{
    public partial class AdminPedidos : System.Web.UI.Page
    {

        BLPedidos pedido = new BLPedidos();
        protected void Page_Load(object sender, EventArgs e)
        {
            new ControlUsuarioLogin().verificaAdmin();
            ViewState["pedido"] = new BLPedidos();
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
            TextBox2.Text = pedido.email;
            RadioButtonList1.SelectedValue = pedido.estado;
            TextBox6.Text = pedido.codigo + "";
            TextBox7.Text = pedido.fecha.ToString();
            reset();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text != String.Empty)
            {
                pedido.codigo = int.Parse(TextBox6.Text);
                pedido.email = TextBox2.Text;
                pedido.estado = RadioButtonList1.SelectedValue.ToString();
                new ManagerPedidos().EditarPedidos(pedido);
                reset();
            }
            else
            {
                pedido = new BLPedidos();
                pedido.email = TextBox2.Text;
                pedido.estado = RadioButtonList1.SelectedValue.ToString();
                pedido.fecha = DateTime.Now;
                new ManagerPedidos().InsertarPedidos(pedido);
                reset();
            }
            
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            pedido.codigo = int.Parse(TextBox6.Text);
            new ManagerPedidos().EliminarPedidos(pedido);
            reset();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            List<BLPedidos> lista = new ManagerPedidos().listaPedidos();
            if (CheckBox1.Checked)
            {
                lista = new ManagerPedidos().listaPedidosFiltradaEstado(lista, RadioButtonList2.SelectedValue.ToString());
            }
            if (CheckBox2.Checked)
            {
                lista = new ManagerPedidos().listaPedidosFiltradaEmail(lista, TextBox5.Text);
            }
            if (CheckBox3.Checked)
            {
                lista = new ManagerPedidos().listaPedidosFiltradaFecha(lista, Calendar2.SelectedDate, Calendar3.SelectedDate);
            }
            GridView1.DataSource = lista;
            GridView1.DataBind();

        }
    }
}