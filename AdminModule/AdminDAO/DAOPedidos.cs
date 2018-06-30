using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using AdminTO;
namespace AdminDAO
{
    public class DAOPedidos
    {
        SqlConnection conexion = new SqlConnection("Data Source=SQL5023.site4now.net;Initial Catalog=DB_A3D05A_holabasededatos2;User Id=DB_A3D05A_holabasededatos2_admin;Password=contraprueba1;");
        String qry = "";
        SqlCommand comando;

        public void InsertarPedido(TOPedidos pedido)
        {
            qry = "INSERT INTO PEDIDO(FECHA,ESTADO_PEDIDO,EMAIL) VALUES(@FE,@ES,@EM);";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@FE", pedido.fecha);
            comando.Parameters.AddWithValue("@ES", pedido.estado);
            comando.Parameters.AddWithValue("@EM", pedido.email);
            String cod = "";
            String qryCODI = "SELECT TOP 1 codigo_pedido FROM pedido WHERE(fecha < GETDATE()) and(email = 'edgardo@ucr.com') ORDER BY FECHA DESC;";
            SqlCommand comandoCODI = new SqlCommand(qryCODI, conexion);


            conexion.Open();


            comando.ExecuteNonQuery();
            cod = comandoCODI.ExecuteScalar().ToString();

            conexion.Close();



        }
        public void EditarPedido(TOPedidos pedido)
        {
            qry = "UPDATE PEDIDO SET ESTADO_PEDIDO = @ES,EMAIL = @EM WHERE CODIGO_PEDIDO = @CO;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ES", pedido.estado);
            comando.Parameters.AddWithValue("@CO", pedido.codigo);
            comando.Parameters.AddWithValue("@EM", pedido.email);


            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }
        public TOPedidos ConsultarPedido(String codigo)
        {
            TOPedidos pedido = new TOPedidos();
            qry = "SELECT * FROM PEDIDO WHERE CODIGO_PEDIDO = @CO; ";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@CO", codigo);


            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pedido.fecha = (DateTime)reader[0];
                    pedido.estado = reader[1].ToString();
                    pedido.codigo = int.Parse(reader[2].ToString());
                    pedido.email = reader[3].ToString();
                    pedido.detalles = new DAODetallePedido().detallesDePedido(pedido.codigo+"");
                   
                }
            }


            conexion.Close();


            return pedido;
        }

        public void EliminarPedido(TOPedidos pedido)
        {
            qry = "DELETE FROM PEDIDO WHERE CODIGO_PEDIDO = @CO; ";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@CO", pedido.codigo);

            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }

        public List<TOPedidos> listaPedidos()
        {
            qry = "SELECT * FROM PEDIDO;";
            comando = new SqlCommand(qry, conexion);
            List<TOPedidos> lista = new List<TOPedidos>();
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOPedidos pedido = new TOPedidos();
                    pedido.fecha = (DateTime)reader[0];
                    pedido.estado = reader[1].ToString();
                    pedido.codigo = int.Parse(reader[2].ToString());
                    pedido.email = reader[3].ToString();
                    pedido.detalles = new DAODetallePedido().detallesDePedido(pedido.codigo.ToString());
                    lista.Add(pedido);
                }
            }


            conexion.Close();


            return lista;
        }

    }
}
