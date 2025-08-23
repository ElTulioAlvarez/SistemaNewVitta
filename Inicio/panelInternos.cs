using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inicio;

namespace Inicio
{
    public partial class panelInternos : Form
    {
        private static Form FormularioActivo = null;
        public panelInternos()
        {
            InitializeComponent();
        }

        

        private void MostrarFormulario(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelInternosDynamic.Controls.Add(formulario);
            panelInternosDynamic.Tag = formulario;
            formulario.Show();
            
            lblInternos.Visible = false;
            btnRegistrar.Visible = false;
            btnModificarInterno.Visible = false;
            btnPagos.Visible = false;
            btnCerrar.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarFormulario(new registroInterno());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de registro de paso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
