using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Entidades;

namespace Inicio
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarVentan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarVentan_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = entryUsuario.Text;
            string contrasena = entryPass.Text;

            if (entryUsuario.Text == "" && entryPass.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entryUsuario.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entryPass.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            CN_DatosUsuario.CN_Usuarios objUsuario = new CN_DatosUsuario.CN_Usuarios();
            List<Usuarios> listaUsuarios = objUsuario.Listar();
            Usuarios usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.usuario == usuario && u.pass == contrasena);
            if (usuarioEncontrado != null)
            {
                MessageBox.Show("¡Bienvenido " + usuarioEncontrado.nombre + "!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir el formulario principal o realizar otras acciones necesarias
                this.Hide(); // Oculta el formulario de login
                Panel formPrincipal = new Panel(usuarioEncontrado.usuario, usuarioEncontrado.pass);
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
