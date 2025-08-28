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
    public class DatosInternoMedicamentos
    {
        public List<InternoMedicamentos> Listar()
        {
            List<InternoMedicamentos> lista = new List<InternoMedicamentos>();

            using (SqlConnection sqlConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdInterno, IdMedicamento, id_usuario FROM InternosMedicamentos\r\n";

                    SqlCommand cmd = new SqlCommand(query, sqlConexion);
                    cmd.CommandType = CommandType.Text;

                    sqlConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new InternoMedicamentos
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                IdInterno = Convert.ToInt32(dr["IdInterno"]),
                                IdMedicamento = Convert.ToInt32(dr["IdMedicamento"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<InternoMedicamentos>();
                }
            }

            return lista;

        }
    }
}
