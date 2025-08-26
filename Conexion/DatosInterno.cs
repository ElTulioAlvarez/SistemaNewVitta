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
    public class DatosInterno
    {
        public List<Internos> Listar()
        {
            List<Internos> lista = new List<Internos>();

            using (SqlConnection sqlConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdInterno, Nombre, FechaNacimiento, Ocupacion, FamiliarResponsable, FechaIngreso, IdPsicologo, IdDoctor, id_usuario FROM Internos\r\n";

                    SqlCommand cmd = new SqlCommand(query, sqlConexion);
                    cmd.CommandType = CommandType.Text;

                    sqlConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Internos
                            {
                                IdInterno = Convert.ToInt32(dr["IdInterno"]),
                                Nombre = dr["Nombre"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Ocupacion = dr["Ocupacion"].ToString(),
                                FamiliarResponsable = dr["FamiliarResponsable"].ToString(),
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                                IdPsicologo = Convert.ToInt32(dr["IdPsicologo"]),
                                IdDoctor = Convert.ToInt32(dr["IdDoctor"]),
                                idUsuario = Convert.ToInt32(dr["id_usuario"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Internos>();
                }
            }

            return lista;

        }
    }
}
