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
    public class InsertarInterno
    {
        public void Agregar(Internos interno)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Insert into Internos (Nombre, FechaNacimiento, Ocupacion, FamiliarResponsable, FechaIngreso, IdPsicologo, IdDoctor) values (@Nombre, @FechaNacimiento, @Ocupacion, @FamiliarResponsable, @FechaIngreso, @IdPsicologo, @IdDoctor)";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Nombre", interno.Nombre.ToString());
                    cmd.Parameters.AddWithValue("@FechaNacimiento", interno.FechaNacimiento.ToString());
                    cmd.Parameters.AddWithValue("@Ocupacion", interno.Ocupacion.ToString());
                    cmd.Parameters.AddWithValue("@FamiliarResponsable", interno.FamiliarResponsable.ToString());
                    cmd.Parameters.AddWithValue("@FechaIngreso", interno.FechaIngreso.ToString());
                    cmd.Parameters.AddWithValue("@IdPsicologo", Convert.ToInt32(interno.IdPsicologo));
                    cmd.Parameters.AddWithValue("@IdDoctor", Convert.ToInt32(interno.IdDoctor));
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el registro: " + ex.Message);
                }
            }


        }
    }
}
