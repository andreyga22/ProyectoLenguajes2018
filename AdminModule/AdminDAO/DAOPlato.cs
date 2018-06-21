using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using AdminTO;


namespace AdminDAO {
    public class DAOPlato {
        private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadena);


        public Boolean agregarPlato(TOPlato plato) {
            Boolean inserto = false;
            try {
                string insert = "insert into Plato (Nombre, Descripcion Precio, Fotografia, Codigo_Plato, Estado_Plato) values (@nom, @des, @pre, @fot, @cod, @est;)";
                SqlCommand sentencia = new SqlCommand(insert, conexion);
                sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
                sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
                sentencia.Parameters.AddWithValue("@pre", plato.Precio);
                sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                sentencia.Parameters.AddWithValue("@est", plato.Estado);

                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) {
                    conexion.Close();
                }
                inserto = true;
            } catch (SqlException ex) {
                throw ex;
            } catch (Exception ex2) {
                throw ex2;
            } finally {
                conexion.Close();
            }
            return inserto;
        }





    }
}
