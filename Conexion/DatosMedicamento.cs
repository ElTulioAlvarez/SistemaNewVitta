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
    public class DatosMedicamento
    {
        public List<Medicamentos> Listar()
        {
            List<Medicamentos> lista = new List<Medicamentos>();

            using (SqlConnection sqlConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdMedicamento, Nombre, Dosis, Frecuencia, id_usuario FROM Medicamentos\r\n";

                    SqlCommand cmd = new SqlCommand(query, sqlConexion);
                    cmd.CommandType = CommandType.Text;

                    sqlConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Medicamentos
                            {
                                IdMedicamento = Convert.ToInt32(dr["IdMedicamento"]),
                                Nombre = dr["Nombre"].ToString(),
                                Dosis = dr["Dosis"].ToString(),
                                Frecuencia = dr["Frecuencia"].ToString(),
                                id_usuario = Convert.ToInt32(dr["id_usuario"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Medicamentos>();
                }
            }

            return lista;

        }
    }
}
