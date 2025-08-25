using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class DatosPsicologo
    {
        public List<Psicologos> Listar()
        {
            List<Psicologos> lista = new List<Psicologos>();

            using (SqlConnection sqlConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Nombre, CedulaProfesional, Especialidad, Telefono FROM Psicologos\r\n";

                    SqlCommand cmd = new SqlCommand(query, sqlConexion);
                    cmd.CommandType = CommandType.Text;

                    sqlConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Psicologos
                            {
                                Nombre = dr["Nombre"].ToString(),
                                CedulaProfesional = dr["CedulaProfesional"].ToString(),
                                Especialidad = dr["Especialidad"].ToString(),
                                Telefono = dr["Telefono"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Psicologos>();
                }
            }

            return lista;

        }
    }
}
