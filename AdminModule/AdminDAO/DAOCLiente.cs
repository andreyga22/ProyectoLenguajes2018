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

        public void InsertarCliente(TOCliente cliente)
        {
            qry = "INSERT INTO CLIENTE(NOMBRE_CLIENTE,APELLIDO1_CLIENTE,APELLIDO2_CLIENTE,EMAIL,TELEFONO,CONTRASENA_CLIENTE,ROL,ESTADO) VALUES(@NO,@PR,@SE,@EM,@TE,@CO,@RO,@ES);";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@NO",cliente.nombreUsuario);
            comando.Parameters.AddWithValue("@PR", cliente.primerApellido);
            comando.Parameters.AddWithValue("@SE", cliente.segundoApellido);
            comando.Parameters.AddWithValue("@EM", cliente.email);
            comando.Parameters.AddWithValue("@TE", cliente.telefono);
            comando.Parameters.AddWithValue("@CO", cliente.contrasena);
            comando.Parameters.AddWithValue("@RO", cliente.rol);
            comando.Parameters.AddWithValue("@ES", cliente.estado);


            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();

                

        }
        public void EditarCliente(TOCliente cliente)
        {
            qry = "UPDATE CLIENTE SET NOMBRE_CLIENTE = @NA, APELLIDO1_CLIENTE = @AP,APELLIDO2_CLIENTE = @APP, EMAIL = @EM,TELEFONO= @TE, CONTRASENA_CLIENTE = @CO, ROL = @RO, ESTADO = @ES WHERE CODIGO_CLIENTE = @ID;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@NA", cliente.nombreUsuario);
            comando.Parameters.AddWithValue("@AP", cliente.primerApellido);
            comando.Parameters.AddWithValue("@ID", cliente.id);
            comando.Parameters.AddWithValue("@RO", cliente.rol);
            comando.Parameters.AddWithValue("@EM", cliente.email);
            comando.Parameters.AddWithValue("@TE", cliente.telefono);
            comando.Parameters.AddWithValue("@CO", cliente.contrasena);
            comando.Parameters.AddWithValue("@APP", cliente.segundoApellido);
            comando.Parameters.AddWithValue("@ES", cliente.estado);


            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }
        public TOCliente ConsultarCliente(String id)
        {
            TOCliente cliente = new TOCliente();
            qry = "SELECT * FROM CLIENTE WHERE EMAIL = @ID;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ID", id);

            
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.nombreUsuario = reader[0].ToString();
                    cliente.primerApellido = reader[1].ToString();
                    cliente.segundoApellido = reader[2].ToString();
                    cliente.email = reader[3].ToString();
                    cliente.telefono= reader[4].ToString();
                    cliente.id = int.Parse(reader[5].ToString());
                    cliente.contrasena = reader[6].ToString();
                    cliente.rol = reader[7].ToString();
                    cliente.estado = Convert.ToBoolean( reader[8]);
                    }
            }

           
            conexion.Close();


            return cliente;
        }

        public TOCliente ConsultarClienteId(String id)
        {
            TOCliente cliente = new TOCliente();
            qry = "SELECT * FROM CLIENTE WHERE CODIGO_CLIENTE = @ID;";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ID", id);


            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.nombreUsuario = reader[0].ToString();
                    cliente.primerApellido = reader[1].ToString();
                    cliente.segundoApellido = reader[2].ToString();
                    cliente.email = reader[3].ToString();
                    cliente.telefono = reader[4].ToString();
                    cliente.id = int.Parse(reader[5].ToString());
                    cliente.contrasena = reader[6].ToString();
                    cliente.rol = reader[7].ToString();
                    cliente.estado = Convert.ToBoolean(reader[8]);
                }
            }


            conexion.Close();


            return cliente;
        }

        public void EliminarCliente(TOCliente cliente)
        {
            qry = "DELETE FROM CLIENTE WHERE CODIGO_CLIENTE = @ID; ";
            comando = new SqlCommand(qry, conexion);
            comando.Parameters.AddWithValue("@ID", cliente.id);
          
            conexion.Open();


            comando.ExecuteNonQuery();


            conexion.Close();
        }

        public List<TOCliente> listaCliente()
        {
           qry = "SELECT * FROM CLIENTE;";
            comando = new SqlCommand(qry, conexion);
            List<TOCliente> lista = new List<TOCliente>();
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOCliente cliente = new TOCliente();
                    cliente.nombreUsuario = reader[0].ToString();
                    cliente.primerApellido = reader[1].ToString();
                    cliente.segundoApellido = reader[2].ToString();
                    cliente.email = reader[3].ToString();
                    cliente.telefono = reader[4].ToString();
                    cliente.id = int.Parse(reader[5].ToString());
                    cliente.contrasena = reader[6].ToString();
                    cliente.rol = reader[7].ToString();
                    cliente.estado = Convert.ToBoolean(reader[8]);
                    lista.Add(cliente);
                }
            }


            conexion.Close();


            return lista;
        }

    }
}
