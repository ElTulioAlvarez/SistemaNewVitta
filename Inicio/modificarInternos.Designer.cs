namespace Inicio
{
    partial class modificarInternos
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.entryBuscarInterno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.entryDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.entryPsicologo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.entryFechaIngreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.entryFamiliar = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryOcupacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.entryNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDoctor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPsicologo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFechaIngreso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFamiliar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOcupacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNacimiento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.dataInternoMedicamentos = new System.Windows.Forms.DataGridView();
            this.DataViewMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarMedicamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrarMedicamento = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataInternoMedicamentos)).BeginInit();
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
            this.btnCerrar.Location = new System.Drawing.Point(618, 597);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblInternos
            // 
            this.lblInternos.BackColor = System.Drawing.Color.Transparent;
            this.lblInternos.Font = new System.Drawing.Font("Segoe UI Semibold", 50F, System.Drawing.FontStyle.Bold);
            this.lblInternos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInternos.Location = new System.Drawing.Point(159, 12);
            this.lblInternos.Name = "lblInternos";
            this.lblInternos.Size = new System.Drawing.Size(537, 91);
            this.lblInternos.TabIndex = 14;
            this.lblInternos.Text = "Modificar Interno";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(159, 109);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(84, 39);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Buscar";
            // 
            // entryBuscarInterno
            // 
            this.entryBuscarInterno.BackColor = System.Drawing.Color.Transparent;
            this.entryBuscarInterno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.entryBuscarInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryBuscarInterno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryBuscarInterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryBuscarInterno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryBuscarInterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.entryBuscarInterno.ItemHeight = 20;
            this.entryBuscarInterno.Location = new System.Drawing.Point(310, 120);
            this.entryBuscarInterno.Name = "entryBuscarInterno";
            this.entryBuscarInterno.Size = new System.Drawing.Size(386, 26);
            this.entryBuscarInterno.TabIndex = 16;
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
            this.entryDoctor.ItemHeight = 20;
            this.entryDoctor.Location = new System.Drawing.Point(310, 390);
            this.entryDoctor.Name = "entryDoctor";
            this.entryDoctor.Size = new System.Drawing.Size(386, 26);
            this.entryDoctor.TabIndex = 42;
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
            this.entryPsicologo.ItemHeight = 20;
            this.entryPsicologo.Location = new System.Drawing.Point(310, 352);
            this.entryPsicologo.Name = "entryPsicologo";
            this.entryPsicologo.Size = new System.Drawing.Size(386, 26);
            this.entryPsicologo.TabIndex = 41;
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
            this.entryFechaIngreso.Location = new System.Drawing.Point(310, 314);
            this.entryFechaIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryFechaIngreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryFechaIngreso.Name = "entryFechaIngreso";
            this.entryFechaIngreso.Size = new System.Drawing.Size(386, 20);
            this.entryFechaIngreso.TabIndex = 40;
            this.entryFechaIngreso.Value = new System.DateTime(2025, 8, 25, 13, 59, 20, 887);
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
            this.entryFamiliar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryFamiliar.ForeColor = System.Drawing.SystemColors.Control;
            this.entryFamiliar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryFamiliar.Location = new System.Drawing.Point(310, 276);
            this.entryFamiliar.Margin = new System.Windows.Forms.Padding(4);
            this.entryFamiliar.Name = "entryFamiliar";
            this.entryFamiliar.PlaceholderText = "";
            this.entryFamiliar.SelectedText = "";
            this.entryFamiliar.Size = new System.Drawing.Size(386, 20);
            this.entryFamiliar.TabIndex = 39;
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
            this.entryOcupacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryOcupacion.ForeColor = System.Drawing.SystemColors.Control;
            this.entryOcupacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryOcupacion.Location = new System.Drawing.Point(310, 238);
            this.entryOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.entryOcupacion.Name = "entryOcupacion";
            this.entryOcupacion.PlaceholderText = "";
            this.entryOcupacion.SelectedText = "";
            this.entryOcupacion.Size = new System.Drawing.Size(386, 20);
            this.entryOcupacion.TabIndex = 38;
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
            this.entryFechaNacimiento.Location = new System.Drawing.Point(310, 201);
            this.entryFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryFechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryFechaNacimiento.Name = "entryFechaNacimiento";
            this.entryFechaNacimiento.Size = new System.Drawing.Size(386, 20);
            this.entryFechaNacimiento.TabIndex = 37;
            this.entryFechaNacimiento.Value = new System.DateTime(2025, 8, 25, 13, 59, 20, 887);
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
            this.entryNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.entryNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.entryNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.entryNombre.Location = new System.Drawing.Point(310, 167);
            this.entryNombre.Margin = new System.Windows.Forms.Padding(4);
            this.entryNombre.Name = "entryNombre";
            this.entryNombre.PlaceholderText = "";
            this.entryNombre.SelectedText = "";
            this.entryNombre.Size = new System.Drawing.Size(386, 20);
            this.entryNombre.TabIndex = 36;
            // 
            // lblDoctor
            // 
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoctor.Location = new System.Drawing.Point(159, 390);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(44, 19);
            this.lblDoctor.TabIndex = 35;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblPsicologo
            // 
            this.lblPsicologo.BackColor = System.Drawing.Color.Transparent;
            this.lblPsicologo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPsicologo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPsicologo.Location = new System.Drawing.Point(159, 352);
            this.lblPsicologo.Name = "lblPsicologo";
            this.lblPsicologo.Size = new System.Drawing.Size(61, 19);
            this.lblPsicologo.TabIndex = 34;
            this.lblPsicologo.Text = "Psicologo";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaIngreso.Location = new System.Drawing.Point(159, 314);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(107, 19);
            this.lblFechaIngreso.TabIndex = 33;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblFamiliar
            // 
            this.lblFamiliar.BackColor = System.Drawing.Color.Transparent;
            this.lblFamiliar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFamiliar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFamiliar.Location = new System.Drawing.Point(159, 276);
            this.lblFamiliar.Name = "lblFamiliar";
            this.lblFamiliar.Size = new System.Drawing.Size(101, 19);
            this.lblFamiliar.TabIndex = 32;
            this.lblFamiliar.Text = "Familiar a Cargo";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOcupacion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOcupacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOcupacion.Location = new System.Drawing.Point(159, 238);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(67, 19);
            this.lblOcupacion.TabIndex = 31;
            this.lblOcupacion.Text = "Ocupación";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNacimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNacimiento.Location = new System.Drawing.Point(159, 201);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(128, 19);
            this.lblNacimiento.TabIndex = 30;
            this.lblNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(159, 164);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 19);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Animated = true;
            this.btnBuscar.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BorderThickness = 1;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(159, 597);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 28);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Animated = true;
            this.btnModificar.BorderColor = System.Drawing.SystemColors.Control;
            this.btnModificar.BorderThickness = 1;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(392, 597);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 28);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataInternoMedicamentos
            // 
            this.dataInternoMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInternoMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataViewMedicamento});
            this.dataInternoMedicamentos.Location = new System.Drawing.Point(159, 438);
            this.dataInternoMedicamentos.Name = "dataInternoMedicamentos";
            this.dataInternoMedicamentos.Size = new System.Drawing.Size(453, 96);
            this.dataInternoMedicamentos.TabIndex = 46;
            // 
            // DataViewMedicamento
            // 
            this.DataViewMedicamento.Frozen = true;
            this.DataViewMedicamento.HeaderText = "Medicamento";
            this.DataViewMedicamento.Name = "DataViewMedicamento";
            this.DataViewMedicamento.Width = 537;
            // 
            // btnModificarMedicamento
            // 
            this.btnModificarMedicamento.Animated = true;
            this.btnModificarMedicamento.BorderColor = System.Drawing.SystemColors.Control;
            this.btnModificarMedicamento.BorderThickness = 1;
            this.btnModificarMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarMedicamento.FillColor = System.Drawing.Color.DarkBlue;
            this.btnModificarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarMedicamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarMedicamento.Location = new System.Drawing.Point(618, 472);
            this.btnModificarMedicamento.Name = "btnModificarMedicamento";
            this.btnModificarMedicamento.Size = new System.Drawing.Size(78, 28);
            this.btnModificarMedicamento.TabIndex = 47;
            this.btnModificarMedicamento.Text = "Modificar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.BorderThickness = 1;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(618, 438);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 28);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrarMedicamento
            // 
            this.btnBorrarMedicamento.Animated = true;
            this.btnBorrarMedicamento.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBorrarMedicamento.BorderThickness = 1;
            this.btnBorrarMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrarMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrarMedicamento.FillColor = System.Drawing.Color.DarkRed;
            this.btnBorrarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrarMedicamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrarMedicamento.Location = new System.Drawing.Point(618, 506);
            this.btnBorrarMedicamento.Name = "btnBorrarMedicamento";
            this.btnBorrarMedicamento.Size = new System.Drawing.Size(78, 28);
            this.btnBorrarMedicamento.TabIndex = 49;
            this.btnBorrarMedicamento.Text = "Borrar";
            // 
            // modificarInternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(863, 637);
            this.Controls.Add(this.btnBorrarMedicamento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificarMedicamento);
            this.Controls.Add(this.dataInternoMedicamentos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
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
            this.Controls.Add(this.entryBuscarInterno);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblInternos);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarInternos";
            this.Text = "modificarInternos";
            ((System.ComponentModel.ISupportInitialize)(this.dataInternoMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInternos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox entryBuscarInterno;
        private Guna.UI2.WinForms.Guna2ComboBox entryDoctor;
        private Guna.UI2.WinForms.Guna2ComboBox entryPsicologo;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryFechaIngreso;
        private Guna.UI2.WinForms.Guna2TextBox entryFamiliar;
        private Guna.UI2.WinForms.Guna2TextBox entryOcupacion;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryFechaNacimiento;
        private Guna.UI2.WinForms.Guna2TextBox entryNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDoctor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPsicologo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFechaIngreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFamiliar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOcupacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNacimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private System.Windows.Forms.DataGridView dataInternoMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataViewMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnModificarMedicamento;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnBorrarMedicamento;
    }
}