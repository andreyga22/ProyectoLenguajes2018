using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;
namespace AdminUI
{
    public partial class UsuarioMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataSource = new managerUsuario().listaUsuario();
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["busqueda"] = TextBox7.Text;
            cargarCampos();
        }

        public void cargarCampos()
        {
            String id = (String)ViewState["busqueda"];
            Label8.Text = id + "casa";
            BLUsuario usuario = new managerUsuario().ConsultarUsuario(id);
            TextBox1.Text = usuario.nombreUsuario;
                TextBox2.Text = usuario.primerApellido;
                TextBox3.Text = usuario.segundoApellido;
                TextBox4.Text = usuario.rol;
                TextBox5.Text = usuario.email;
                TextBox6.Text = usuario.contrasena;
            TextBox8.Text = usuario.id + "";
        }

       

        public BLUsuario crearUsuario()
        {
            BLUsuario usuario = new BLUsuario();
            if (TextBox8.Text.Equals("") == false)
            {
                usuario.id = int.Parse(TextBox8.Text);
            }
             usuario.nombreUsuario = TextBox1.Text;
             usuario.primerApellido = TextBox2.Text;
             usuario.segundoApellido = TextBox3.Text;
             usuario.rol = TextBox4.Text;
             usuario.email = TextBox5.Text;
             usuario.contrasena = TextBox6.Text;
            return usuario;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            new managerUsuario().InsertarUsuario(crearUsuario());
            GridView1.DataSource = new managerUsuario().listaUsuario();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            new managerUsuario().EditarUsuario(crearUsuario());
            GridView1.DataSource = new managerUsuario().listaUsuario();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            new managerUsuario().EliminarUsuario(crearUsuario());
            GridView1.DataSource = new managerUsuario().listaUsuario();
            GridView1.DataBind();
        }
    }
}