namespace Inicio
{
    partial class registroInterno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.lblInternos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNacimiento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOcupacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFamiliar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFechaIngreso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPsicologo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDoctor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.entryNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.entryOcupacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryFamiliar = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryFechaIngreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.entryPsicologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.entryDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Animated = true;
            this.btnCerrar.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.BorderThickness = 1;
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(663, 597);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 28);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblInternos
            // 
            this.lblInternos.BackColor = System.Drawing.Color.Transparent;
            this.lblInternos.Font = new System.Drawing.Font("Segoe UI Semibold", 50F, System.Drawing.FontStyle.Bold);
            this.lblInternos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInternos.Location = new System.Drawing.Point(120, 12);
            this.lblInternos.Name = "lblInternos";
            this.lblInternos.Size = new System.Drawing.Size(621, 91);
            this.lblInternos.TabIndex = 14;
            this.lblInternos.Text = "Registro de Internos";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(120, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 30);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNacimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNacimiento.Location = new System.Drawing.Point(120, 180);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(191, 30);
            this.lblNacimiento.TabIndex = 16;
            this.lblNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOcupacion.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblOcupacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOcupacion.Location = new System.Drawing.Point(120, 230);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(99, 30);
            this.lblOcupacion.TabIndex = 17;
            this.lblOcupacion.Text = "Ocupación";
            // 
            // lblFamiliar
            // 
            this.lblFamiliar.BackColor = System.Drawing.Color.Transparent;
            this.lblFamiliar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblFamiliar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFamiliar.Location = new System.Drawing.Point(120, 280);
            this.lblFamiliar.Name = "lblFamiliar";
            this.lblFamiliar.Size = new System.Drawing.Size(148, 30);
            this.lblFamiliar.TabIndex = 18;
            this.lblFamiliar.Text = "Familiar a Cargo";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaIngreso.Location = new System.Drawing.Point(120, 330);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(159, 30);
            this.lblFechaIngreso.TabIndex = 19;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblPsicologo
            // 
            this.lblPsicologo.BackColor = System.Drawing.Color.Transparent;
            this.lblPsicologo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPsicologo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPsicologo.Location = new System.Drawing.Point(120, 380);
            this.lblPsicologo.Name = "lblPsicologo";
            this.lblPsicologo.Size = new System.Drawing.Size(91, 30);
            this.lblPsicologo.TabIndex = 20;
            this.lblPsicologo.Text = "Psicologo";
            // 
            // lblDoctor
            // 
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoctor.Location = new System.Drawing.Point(120, 430);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(64, 30);
            this.lblDoctor.TabIndex = 21;
            this.lblDoctor.Text = "Doctor";
            // 
            // entryNombre
            // 
            this.entryNombre.Animated = true;
            this.entryNombre.BorderRadius = 5;
            this.entryNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entryNombre.CustomizableEdges.BottomLeft = false;
            this.entryNombre.CustomizableEdges.BottomRight = false;
            this.entryNombre.CustomizableEdges.TopLeft = false;
            this.entryNombre.CustomizableEdges.TopRight = false;
            this.entryNombre.DefaultText = "";
            this.entryNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.entryNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.entryNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.entryNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.entryNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryNombre.Location = new System.Drawing.Point(541, 136);
            this.entryNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryNombre.Name = "entryNombre";
            this.entryNombre.PlaceholderText = "";
            this.entryNombre.SelectedText = "";
            this.entryNombre.Size = new System.Drawing.Size(200, 27);
            this.entryNombre.TabIndex = 22;
            // 
            // entryFechaNacimiento
            // 
            this.entryFechaNacimiento.BorderColor = System.Drawing.SystemColors.Control;
            this.entryFechaNacimiento.BorderThickness = 1;
            this.entryFechaNacimiento.Checked = true;
            this.entryFechaNacimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entryFechaNacimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.entryFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.entryFechaNacimiento.Location = new System.Drawing.Point(541, 183);
            this.entryFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryFechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryFechaNacimiento.Name = "entryFechaNacimiento";
            this.entryFechaNacimiento.Size = new System.Drawing.Size(200, 27);
            this.entryFechaNacimiento.TabIndex = 23;
            this.entryFechaNacimiento.Value = new System.DateTime(2025, 8, 25, 13, 59, 20, 887);
            // 
            // entryOcupacion
            // 
            this.entryOcupacion.Animated = true;
            this.entryOcupacion.BorderRadius = 5;
            this.entryOcupacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entryOcupacion.CustomizableEdges.BottomLeft = false;
            this.entryOcupacion.CustomizableEdges.BottomRight = false;
            this.entryOcupacion.CustomizableEdges.TopLeft = false;
            this.entryOcupacion.CustomizableEdges.TopRight = false;
            this.entryOcupacion.DefaultText = "";
            this.entryOcupacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.entryOcupacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.entryOcupacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryOcupacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryOcupacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryOcupacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryOcupacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.entryOcupacion.ForeColor = System.Drawing.SystemColors.Control;
            this.entryOcupacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryOcupacion.Location = new System.Drawing.Point(541, 236);
            this.entryOcupacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryOcupacion.Name = "entryOcupacion";
            this.entryOcupacion.PlaceholderText = "";
            this.entryOcupacion.SelectedText = "";
            this.entryOcupacion.Size = new System.Drawing.Size(200, 27);
            this.entryOcupacion.TabIndex = 24;
            // 
            // entryFamiliar
            // 
            this.entryFamiliar.Animated = true;
            this.entryFamiliar.BorderRadius = 5;
            this.entryFamiliar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entryFamiliar.CustomizableEdges.BottomLeft = false;
            this.entryFamiliar.CustomizableEdges.BottomRight = false;
            this.entryFamiliar.CustomizableEdges.TopLeft = false;
            this.entryFamiliar.CustomizableEdges.TopRight = false;
            this.entryFamiliar.DefaultText = "";
            this.entryFamiliar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.entryFamiliar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.entryFamiliar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryFamiliar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.entryFamiliar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryFamiliar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryFamiliar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.entryFamiliar.ForeColor = System.Drawing.SystemColors.Control;
            this.entryFamiliar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryFamiliar.Location = new System.Drawing.Point(541, 286);
            this.entryFamiliar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryFamiliar.Name = "entryFamiliar";
            this.entryFamiliar.PlaceholderText = "";
            this.entryFamiliar.SelectedText = "";
            this.entryFamiliar.Size = new System.Drawing.Size(200, 27);
            this.entryFamiliar.TabIndex = 25;
            // 
            // entryFechaIngreso
            // 
            this.entryFechaIngreso.BorderColor = System.Drawing.SystemColors.Control;
            this.entryFechaIngreso.BorderThickness = 1;
            this.entryFechaIngreso.Checked = true;
            this.entryFechaIngreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entryFechaIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.entryFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.entryFechaIngreso.Location = new System.Drawing.Point(541, 336);
            this.entryFechaIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryFechaIngreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryFechaIngreso.Name = "entryFechaIngreso";
            this.entryFechaIngreso.Size = new System.Drawing.Size(200, 27);
            this.entryFechaIngreso.TabIndex = 26;
            this.entryFechaIngreso.Value = new System.DateTime(2025, 8, 25, 13, 59, 20, 887);
            // 
            // entryPsicologo
            // 
            this.entryPsicologo.BackColor = System.Drawing.Color.Transparent;
            this.entryPsicologo.BorderColor = System.Drawing.SystemColors.Control;
            this.entryPsicologo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entryPsicologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryPsicologo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryPsicologo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryPsicologo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryPsicologo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryPsicologo.ForeColor = System.Drawing.SystemColors.Control;
            this.entryPsicologo.ItemHeight = 27;
            this.entryPsicologo.Location = new System.Drawing.Point(541, 383);
            this.entryPsicologo.Name = "entryPsicologo";
            this.entryPsicologo.Size = new System.Drawing.Size(200, 33);
            this.entryPsicologo.TabIndex = 27;
            // 
            // entryDoctor
            // 
            this.entryDoctor.BackColor = System.Drawing.Color.Transparent;
            this.entryDoctor.BorderColor = System.Drawing.SystemColors.Control;
            this.entryDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entryDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.entryDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.entryDoctor.ItemHeight = 27;
            this.entryDoctor.Location = new System.Drawing.Point(541, 430);
            this.entryDoctor.Name = "entryDoctor";
            this.entryDoctor.Size = new System.Drawing.Size(200, 33);
            this.entryDoctor.TabIndex = 28;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Animated = true;
            this.btnRegistrar.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.BorderThickness = 1;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(120, 597);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(78, 28);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // registroInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(863, 637);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.entryDoctor);
            this.Controls.Add(this.entryPsicologo);
            this.Controls.Add(this.entryFechaIngreso);
            this.Controls.Add(this.entryFamiliar);
            this.Controls.Add(this.entryOcupacion);
            this.Controls.Add(this.entryFechaNacimiento);
            this.Controls.Add(this.entryNombre);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPsicologo);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFamiliar);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInternos);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registroInterno";
            this.Text = "registroInterno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInternos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNacimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOcupacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFamiliar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFechaIngreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPsicologo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDoctor;
        private Guna.UI2.WinForms.Guna2TextBox entryNombre;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryFechaNacimiento;
        private Guna.UI2.WinForms.Guna2TextBox entryOcupacion;
        private Guna.UI2.WinForms.Guna2TextBox entryFamiliar;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryFechaIngreso;
        private Guna.UI2.WinForms.Guna2ComboBox entryPsicologo;
        private Guna.UI2.WinForms.Guna2ComboBox entryDoctor;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
    }
}