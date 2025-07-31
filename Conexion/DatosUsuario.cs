using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Conexion
{
    public class DatosUsuario
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            using (SqlConnection sqlConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT id_usuario, nombre, usuario, pass, rol FROM Usuarios\r\n";

                    SqlCommand cmd = new SqlCommand(query, sqlConexion);
                    cmd.CommandType = CommandType.Text;

                    sqlConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                usuario = dr["usuario"].ToString(),
                                pass = dr["pass"].ToString(),
                                rol = dr["rol"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuarios>();
                }
            }

            return lista;

        }
    }
}
