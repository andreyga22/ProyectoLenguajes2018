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
                string insert = "insert into Plato (Nombre, Descripcion, Precio, Foto, Estado_Plato) values (@nom, @des, @pre, @fot, @est);";
                SqlCommand sentencia = new SqlCommand(insert, conexion);
                sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
                sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
                sentencia.Parameters.AddWithValue("@pre", plato.Precio);
                sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
                //sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
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

        public Boolean borrarPlato(int cod) {
            try {
                string select = "delete from Plato where Codigo_Plato = @cod;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
                sentencia.Parameters.AddWithValue("@cod", cod);

                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();

                if (conexion.State != ConnectionState.Closed) {
                    conexion.Close();
                }
                return true;
            } catch (SqlException ex) {
                throw ex;
            } catch (Exception ex2) {
                throw ex2;
            } finally {
                conexion.Close();
            }
        }

        public TOPlato buscarPlato(TOPlato plato) {

            try {
                string select = "select * from Plato where Codigo_Plato = @cod;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);

                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                SqlDataReader reader = sentencia.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        plato.Nombre = reader.GetString(0);
                        plato.Descripcion = reader.GetString(1);
                        plato.Precio = reader.GetInt32(2);
                        plato.Estado = reader.GetBoolean(4);
                        plato.Fotografia = reader.GetString(5);
                    }
                }
                
                if (conexion.State != ConnectionState.Closed) {
                    conexion.Close();
                }
                return plato;
            } catch (SqlException ex) {
                throw ex;
            } catch (Exception ex2) {
                throw ex2;
            } finally {
                conexion.Close();
            }
        }


        public List<TOPlato> listaPlatos () {
            try {
                string select = "select * from Plato;";
                SqlCommand sentencia = new SqlCommand(select, conexion);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sentencia;
                adapter.Fill(table);
                List<TOPlato> lista = new List<TOPlato>();

                for (int x = 0; x < table.Rows.Count; x++) {
                    TOPlato plato = new TOPlato();
                    plato.Codigo = Convert.ToInt32(table.Rows[x]["Codigo_Plato"]);
                    plato.Descripcion = Convert.ToString(table.Rows[x]["Descripcion"]);
                    plato.Nombre = Convert.ToString(table.Rows[x]["Nombre"]);
                    plato.Estado = Convert.ToBoolean(table.Rows[x]["Estado_Plato"]);
                    plato.Precio = Convert.ToDouble(table.Rows[x]["Precio"]);
                    plato.Fotografia = Convert.ToString(table.Rows[x]["Foto"]);
                    lista.Add(plato);
                } 
                
                return lista;
            } catch (SqlException ex) {
                throw ex;
            } catch (Exception ex2) {
                throw ex2;
            } finally {
                conexion.Close();
            }
        }
















    }
}
