using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class modificarInternos : Form
    {
        string Usuario;
        int idUsuario;
        public modificarInternos(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            CN_DatosUsuario.CN_Usuarios objUsuario = new CN_DatosUsuario.CN_Usuarios();
            List<Usuarios> listaUsuarios = objUsuario.Listar();
            Usuarios usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.usuario == Usuario);
            int idUsuario = usuarioEncontrado.id_usuario;
            this.idUsuario = idUsuario;

            //Inicializar el comboBox con los nombres de los internos
            CN_DatosInterno cN_DatosInterno = new CN_DatosInterno();
            Internos internos = new Internos();

            CN_DatosDoctor cN_DatosDoctor = new CN_DatosDoctor();
            Doctores doctor = new Doctores();

            CN_DatosPsicologo cN_DatosPsicologo = new CN_DatosPsicologo();
            Psicologos psicologo = new Psicologos();


            List<Doctores> listaDoctores = cN_DatosDoctor.Listar();
            List<Psicologos> listaPsicologos = cN_DatosPsicologo.Listar();
            List<Internos> listaInternos = cN_DatosInterno.Listar();

            foreach (Doctores doc in listaDoctores)
            {
                entryDoctor.Items.Add(doc.Nombre);
            }
            foreach (Psicologos psi in listaPsicologos)
            {
                entryPsicologo.Items.Add(psi.Nombre);
            }
            foreach (Internos interno in listaInternos)
            {
                entryBuscarInterno.Items.Add(interno.Nombre);
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {// Buscar el interno seleccionado y cargar sus datos en los campos de texto
            if (entryBuscarInterno.Text.Equals(""))
            {
                MessageBox.Show("Por favor, seleccione un interno para modificar.");
            }
            else
            {
                CN_DatosInterno cN_DatosInterno = new CN_DatosInterno();
                Internos interno = new Internos();
                interno = cN_DatosInterno.Listar().Find(i => i.Nombre.Equals((entryBuscarInterno.Text)));

                CN_DatosInternosMedicamentos cN_DatosInternosMedicamentos = new CN_DatosInternosMedicamentos();
                List<InternoMedicamentos> listaInternosMedicamentos = cN_DatosInternosMedicamentos.Listar();

                CN_DatosMedicamento cN_DatosMedicamento = new CN_DatosMedicamento();
                List<Medicamentos> listaMedicamentos = cN_DatosMedicamento.Listar();

                entryNombre.Text = interno.Nombre;
                entryFechaNacimiento.Text = interno.FechaNacimiento.ToString();
                entryOcupacion.Text = interno.Ocupacion;
                entryFamiliar.Text = interno.FamiliarResponsable;
                entryFechaIngreso.Text = interno.FechaIngreso.ToString();
                entryPsicologo.SelectedIndex = interno.IdPsicologo - 1;
                entryDoctor.SelectedIndex = interno.IdDoctor - 1;

                dataInternoMedicamentos.Rows.Clear();
                for (int i = 0; i < listaInternosMedicamentos.Count; i++)
                {
                    if (listaInternosMedicamentos[i].IdInterno == interno.IdInterno)
                    {
                        dataInternoMedicamentos.Rows.Add(listaMedicamentos[listaInternosMedicamentos[i].IdMedicamento].Nombre);
                    }
                }
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {// Mensaje de confirmación antes de modificar
            if (entryBuscarInterno.Text.Equals(""))
            {
                MessageBox.Show("Por favor, intenta buscar un interno a modificar");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar el registro del interno?", "Confirmar modificación", botones, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    if (entryNombre.Text.Equals("") || entryFechaNacimiento.Text.Equals("") || entryOcupacion.Text.Equals("") || entryFamiliar.Text.Equals("") || entryFechaIngreso.Text.Equals("") || entryPsicologo.Text.Equals("") || entryDoctor.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                    }
                    else
                    {
                        try
                        {
                            CN_DatosInterno cN_DatosInterno = new CN_DatosInterno();
                            Internos interno = new Internos();
                            ActualizarDatosInterno actualizarDatosInterno = new ActualizarDatosInterno();
                            int idInterno = cN_DatosInterno.Listar().Find(i => i.Nombre.Equals((entryBuscarInterno.Text))).IdInterno;
                            interno.Nombre = entryNombre.Text;
                            interno.FechaNacimiento = Convert.ToDateTime(entryFechaNacimiento.Text);
                            interno.Ocupacion = entryOcupacion.Text;
                            interno.FamiliarResponsable = entryFamiliar.Text;
                            interno.FechaIngreso = Convert.ToDateTime(entryFechaIngreso.Text);
                            interno.IdPsicologo = entryPsicologo.SelectedIndex + 1;
                            interno.IdDoctor = entryDoctor.SelectedIndex + 1;
                            interno.idUsuario = Convert.ToInt32(idUsuario);
                            interno.IdInterno = idInterno;
                            actualizarDatosInterno.Actualizar(interno);
                            MessageBox.Show("Registro modificado correctamente.");
                            // Limpiar los campos de texto
                            entryBuscarInterno.Text = "";
                            entryNombre.Text = "";
                            entryFechaNacimiento.Text = "";
                            entryOcupacion.Text = "";
                            entryFamiliar.Text = "";
                            entryFechaIngreso.Text = "";
                            entryPsicologo.SelectedIndex = -1;
                            entryDoctor.SelectedIndex = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar el registro: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
    }
}
