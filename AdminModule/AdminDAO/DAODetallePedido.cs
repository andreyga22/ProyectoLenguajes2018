using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using AdminTO;
namespace AdminDAO
{
   public class DAODetallePedido
    {
        SqlConnection conexion = new SqlConnection("Data Source=SQL5023.site4now.net;Initial Catalog=DB_A3D05A_holabasededatos2;User Id=DB_A3D05A_holabasededatos2_admin;Password=contraprueba1;");
        String qry = "";
        SqlCommand comando;

        public void InsertarDPedido(TODetallePedido pedidoD,String idPedido)
        {
            qry = "INSERT INTO DETALLE_PEDIDO(CODIGO_PEDIDO,CODIGO_PLATO,CANTIDAD_PRODUCTO) VALUES(@CP,@CPP,@CPR);";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@CP", pedidoD.CODIGO_PEDIDO);
            comando.Parameters.AddWithValue("@CPP", pedidoD.CODIGO_PLATO);
            comando.Parameters.AddWithValue("@CPR", pedidoD.CANTIDAD_PRODUCTO);



            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();



        }

        public List<TODetallePedido> detallesDePedido(String idPedido)
        {
            qry = "SELECT * FROM DETALLE_PEDIDO where CODIGO_PEDIDO = @CP;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@CP", idPedido);
            List<TODetallePedido> lista = new List<TODetallePedido>();
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TODetallePedido pedidoD = new TODetallePedido();
                    pedidoD.CODIGO_PEDIDO = int.Parse(reader[0].ToString());
                    pedidoD.CODIGO_PLATO = int.Parse(reader[1].ToString());
                    pedidoD.CANTIDAD_PRODUCTO = int.Parse(reader[2].ToString());
                    TOPlato plato = new TOPlato();
                    plato.Codigo = pedidoD.CODIGO_PLATO;
                    pedidoD.plato = new DAOPlato().buscarPlato(plato);
                    lista.Add(pedidoD);
                }
            }


            conexion.Close();


            return lista;
        }

    }


}
