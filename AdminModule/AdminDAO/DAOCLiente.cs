using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using AdminTO;
namespace AdminDAO
{
    public class DAOCLiente
    {

        SqlConnection conexion = new SqlConnection("Data Source=SQL5023.site4now.net;Initial Catalog=DB_A3D05A_holabasededatos2;User Id=DB_A3D05A_holabasededatos2_admin;Password=contraprueba1;");
        String qry = "";
        SqlCommand comando;

        public void InsertarCLIENTE(TOCLIENTE cliente)
        {
            qry = "INSERT INTO CLIENTE(NOMBRE_CLIENTE, APELLIDO_CLIENTE, ROL,EMAIL_CLIENTE,TELEFONO,CONTRASENA,APELLIDO2_CLIENTE) VALUES(@NA,@AP,@RO,@EM,@CO,@APP);";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@NA",usuario.nombreUsuario);
            comando.Parameters.AddWithValue("@AP", usuario.primerApellido);
            comando.Parameters.AddWithValue("@RO", usuario.rol);
            comando.Parameters.AddWithValue("@EM", usuario.email);
            comando.Parameters.AddWithValue("@CO", usuario.contrasena);
            comando.Parameters.AddWithValue("@APP", usuario.segundoApellido);

           
            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();

                

        }
        public void EditarUsuario(TOCliente usuario)
        {
            qry = "UPDATE CLIENTE SET NOMBRE_CLIENTE = @NA, APELLIDO_CLIENTE = @AP, ROL = @RO, EMAIL_CLIENTE = @EM, CONTRASENA = @CO, APELLIDO2_CLIENTE = @APP WHERE ID = @ID;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@NA", usuario.nombreUsuario);
            comando.Parameters.AddWithValue("@AP", usuario.primerApellido);
            comando.Parameters.AddWithValue("@ID", usuario.id);
            comando.Parameters.AddWithValue("@RO", usuario.rol);
            comando.Parameters.AddWithValue("@EM", usuario.email);
            comando.Parameters.AddWithValue("@CO", usuario.contrasena);
            comando.Parameters.AddWithValue("@APP", usuario.segundoApellido);


            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }
        public TOCliente ConsultarUsuario(String id)
        {
            TOCliente usuario = new TOCliente();
            qry = "SELECT * FROM CLIENTE WHERE ID = @ID; ";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ID", id);

            
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuario.nombreUsuario = reader[0].ToString();
                    usuario.primerApellido = reader[1].ToString();
                    usuario.id = int.Parse(reader[2].ToString());
                    usuario.rol = reader[3].ToString();
                    usuario.email = reader[4].ToString();
                    usuario.contrasena = reader[5].ToString();
                    usuario.segundoApellido = reader[6].ToString();
                }
            }

           
            conexion.Close();


            return usuario;
        }

        public void EliminarUsuario(TOCliente usuario)
        {
            qry = "DELETE FROM CLIENTE WHERE ID = @ID; ";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ID", usuario.id);
          
            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }

        public List<TOCliente> listaUsuario()
        {
           qry = "SELECT * FROM USUARIO;";
            comando = new SqlCommand(qry, conexion);
            List<TOCliente> lista = new List<TOCliente>();
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOCliente usuario = new TOCliente();
                    usuario.nombreUsuario = reader[0].ToString();
                    usuario.primerApellido = reader[1].ToString();
                    usuario.id = int.Parse(reader[2].ToString());
                    usuario.rol = reader[3].ToString();
                    usuario.email = reader[4].ToString();
                    usuario.contrasena = reader[5].ToString();
                    usuario.segundoApellido = reader[6].ToString();
                    lista.Add(usuario);
                }
            }


            conexion.Close();


            return lista;
        }

    }
}
