using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Entidades;

namespace Inicio
{
    public partial class registroInterno : Form
    {
        string Usuario;
        int idUsuario;
        public registroInterno(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            CN_DatosUsuario.CN_Usuarios objUsuario = new CN_DatosUsuario.CN_Usuarios();
            List<Usuarios> listaUsuarios = objUsuario.Listar();
            Usuarios usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.usuario == Usuario);
            int idUsuario = usuarioEncontrado.id_usuario;
            this.idUsuario = idUsuario;


            // Cargar datos en los ComboBox
            CN_DatosPsicologo cN_DatosPsicologo = new CN_DatosPsicologo();
            foreach (var psicologo in cN_DatosPsicologo.Listar())
            {
                entryPsicologo.Items.Add(psicologo.Nombre);
            }

            CN_DatosDoctor cN_DatosDoctor = new CN_DatosDoctor();
            foreach (var doctor in cN_DatosDoctor.Listar())
            {
                entryDoctor.Items.Add(doctor.Nombre);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (entryNombre.Text != "" && entryFechaNacimiento.Text != "" && entryFamiliar.Text != "" && entryDoctor.Text != "" && entryFechaIngreso.Text != "" && entryOcupacion.Text != "" && entryPsicologo.Text != "")
            {
                try
                {
                    Internos nuevoInterno = new Internos
                    {
                        Nombre = entryNombre.Text,
                        FechaNacimiento = DateTime.Parse(entryFechaNacimiento.Text),
                        Ocupacion = entryOcupacion.Text,
                        FamiliarResponsable = entryFamiliar.Text,
                        FechaIngreso = DateTime.Parse(entryFechaIngreso.Text),
                        IdPsicologo = entryPsicologo.SelectedIndex+1,
                        IdDoctor = entryDoctor.SelectedIndex+1,
                        idUsuario = idUsuario
                    };
                    InsertarInterno insertarInterno = new InsertarInterno();
                    insertarInterno.Agregar(nuevoInterno);

                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
