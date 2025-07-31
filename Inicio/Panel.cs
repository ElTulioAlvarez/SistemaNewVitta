using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Panel : Form
    {
        private string usuario;
        private string contra;

        private static Form FormularioActivo = null;
        public Panel(string usuario, string pass)
        {
            InitializeComponent();

            this.usuario = usuario;
            contra = pass;

            windowBar.Text = $"Inicio {usuario}";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            panelDynamic.Controls.Add(formulario);
            panelDynamic.Tag = formulario;
            formulario.Show();
        }

        private void btnCerrarVentan_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnMinimizarVentan_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInternos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarFormulario(new panelInternos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de registro de paso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
