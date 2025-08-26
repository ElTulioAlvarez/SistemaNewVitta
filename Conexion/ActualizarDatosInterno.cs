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
    public class ActualizarDatosInterno
    {
        public void Actualizar(Internos interno)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE Internos SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Ocupacion = @Ocupacion, FamiliarResponsable = @FamiliarResponsable, FechaIngreso = @FechaIngreso, IdPsicologo = @IdPsicologo, IdDoctor = @IdDoctor, id_usuario = @id_usuario WHERE IdInterno = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Nombre", interno.Nombre.ToString());
                    cmd.Parameters.AddWithValue("@FechaNacimiento", interno.FechaNacimiento.ToString());
                    cmd.Parameters.AddWithValue("@Ocupacion", interno.Ocupacion.ToString());
                    cmd.Parameters.AddWithValue("@FamiliarResponsable", interno.FamiliarResponsable.ToString());
                    cmd.Parameters.AddWithValue("@FechaIngreso", interno.FechaIngreso.ToString());
                    cmd.Parameters.AddWithValue("@IdPsicologo", Convert.ToInt32(interno.IdPsicologo));
                    cmd.Parameters.AddWithValue("@IdDoctor", Convert.ToInt32(interno.IdDoctor));
                    cmd.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(interno.idUsuario));
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(interno.IdInterno));
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
