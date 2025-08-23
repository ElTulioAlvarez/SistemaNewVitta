namespace Inicio
{
    partial class Panel
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.windowBar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDynamic = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEgresos = new Guna.UI2.WinForms.Guna2Button();
            this.btnIngresos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPsicologos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctores = new Guna.UI2.WinForms.Guna2Button();
            this.btnInternos = new Guna.UI2.WinForms.Guna2Button();
            this.lblNewVittaIcon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMinimizarVentan = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarVentan = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBar
            // 
            this.windowBar.AutoSize = false;
            this.windowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.windowBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBar.ForeColor = System.Drawing.SystemColors.Control;
            this.windowBar.Location = new System.Drawing.Point(1, 1);
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(1038, 20);
            this.windowBar.TabIndex = 17;
            this.windowBar.Text = "Inicio";
            this.windowBar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.windowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelDynamic);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Location = new System.Drawing.Point(1, 22);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1038, 643);
            this.panelMain.TabIndex = 20;
            // 
            // panelDynamic
            // 
            this.panelDynamic.Location = new System.Drawing.Point(172, 3);
            this.panelDynamic.Name = "panelDynamic";
            this.panelDynamic.Size = new System.Drawing.Size(863, 637);
            this.panelDynamic.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnCerrar);
            this.guna2Panel1.Controls.Add(this.btnEgresos);
            this.guna2Panel1.Controls.Add(this.btnIngresos);
            this.guna2Panel1.Controls.Add(this.btnPsicologos);
            this.guna2Panel1.Controls.Add(this.btnDoctores);
            this.guna2Panel1.Controls.Add(this.btnInternos);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(170, 652);
            this.guna2Panel1.TabIndex = 0;
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
            this.btnCerrar.Location = new System.Drawing.Point(48, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 28);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEgresos
            // 
            this.btnEgresos.Animated = true;
            this.btnEgresos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEgresos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEgresos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEgresos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEgresos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEgresos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEgresos.ForeColor = System.Drawing.Color.White;
            this.btnEgresos.Image = global::Inicio.Properties.Resources.btnEgresos1;
            this.btnEgresos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEgresos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEgresos.Location = new System.Drawing.Point(1, 205);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(168, 37);
            this.btnEgresos.TabIndex = 5;
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIngresos
            // 
            this.btnIngresos.Animated = true;
            this.btnIngresos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnIngresos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Image = global::Inicio.Properties.Resources.btnIngresos1;
            this.btnIngresos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIngresos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnIngresos.Location = new System.Drawing.Point(1, 155);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(168, 37);
            this.btnIngresos.TabIndex = 4;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPsicologos
            // 
            this.btnPsicologos.Animated = true;
            this.btnPsicologos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPsicologos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPsicologos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPsicologos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPsicologos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPsicologos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPsicologos.ForeColor = System.Drawing.Color.White;
            this.btnPsicologos.Image = global::Inicio.Properties.Resources.btnPsicologos;
            this.btnPsicologos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPsicologos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPsicologos.Location = new System.Drawing.Point(1, 105);
            this.btnPsicologos.Name = "btnPsicologos";
            this.btnPsicologos.Size = new System.Drawing.Size(168, 37);
            this.btnPsicologos.TabIndex = 3;
            this.btnPsicologos.Text = "Psicologos";
            this.btnPsicologos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDoctores
            // 
            this.btnDoctores.Animated = true;
            this.btnDoctores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnDoctores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoctores.ForeColor = System.Drawing.Color.White;
            this.btnDoctores.Image = global::Inicio.Properties.Resources.btnDoctores;
            this.btnDoctores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctores.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDoctores.Location = new System.Drawing.Point(1, 55);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(168, 37);
            this.btnDoctores.TabIndex = 2;
            this.btnDoctores.Text = "Doctores";
            this.btnDoctores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInternos
            // 
            this.btnInternos.Animated = true;
            this.btnInternos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInternos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInternos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInternos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInternos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnInternos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnInternos.ForeColor = System.Drawing.Color.White;
            this.btnInternos.Image = global::Inicio.Properties.Resources.btnInternos1;
            this.btnInternos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInternos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnInternos.Location = new System.Drawing.Point(1, 5);
            this.btnInternos.Name = "btnInternos";
            this.btnInternos.Size = new System.Drawing.Size(168, 37);
            this.btnInternos.TabIndex = 1;
            this.btnInternos.Text = "Internos";
            this.btnInternos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInternos.Click += new System.EventHandler(this.btnInternos_Click);
            // 
            // lblNewVittaIcon
            // 
            this.lblNewVittaIcon.AutoSize = false;
            this.lblNewVittaIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblNewVittaIcon.BackgroundImage = global::Inicio.Properties.Resources.newVittaIcon;
            this.lblNewVittaIcon.Location = new System.Drawing.Point(2, 2);
            this.lblNewVittaIcon.Name = "lblNewVittaIcon";
            this.lblNewVittaIcon.Size = new System.Drawing.Size(17, 17);
            this.lblNewVittaIcon.TabIndex = 19;
            this.lblNewVittaIcon.Text = null;
            // 
            // btnMinimizarVentan
            // 
            this.btnMinimizarVentan.BackColor = System.Drawing.Color.White;
            this.btnMinimizarVentan.BackgroundImage = global::Inicio.Properties.Resources.btnCerrarVentana;
            this.btnMinimizarVentan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizarVentan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarVentan.CustomImages.Image = global::Inicio.Properties.Resources.btnMinimizarVentana;
            this.btnMinimizarVentan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimizarVentan.CustomImages.ImageSize = new System.Drawing.Size(17, 17);
            this.btnMinimizarVentan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizarVentan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizarVentan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimizarVentan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimizarVentan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnMinimizarVentan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizarVentan.ForeColor = System.Drawing.Color.White;
            this.btnMinimizarVentan.ImageSize = new System.Drawing.Size(17, 17);
            this.btnMinimizarVentan.Location = new System.Drawing.Point(994, 2);
            this.btnMinimizarVentan.Name = "btnMinimizarVentan";
            this.btnMinimizarVentan.Size = new System.Drawing.Size(17, 17);
            this.btnMinimizarVentan.TabIndex = 18;
            this.btnMinimizarVentan.Click += new System.EventHandler(this.btnMinimizarVentan_Click);
            // 
            // btnCerrarVentan
            // 
            this.btnCerrarVentan.BackColor = System.Drawing.Color.White;
            this.btnCerrarVentan.BackgroundImage = global::Inicio.Properties.Resources.btnCerrarVentana;
            this.btnCerrarVentan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarVentan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVentan.CustomImages.Image = global::Inicio.Properties.Resources.btnCerrarVentana;
            this.btnCerrarVentan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrarVentan.CustomImages.ImageSize = new System.Drawing.Size(17, 17);
            this.btnCerrarVentan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarVentan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarVentan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarVentan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarVentan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCerrarVentan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarVentan.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVentan.ImageSize = new System.Drawing.Size(17, 17);
            this.btnCerrarVentan.Location = new System.Drawing.Point(1020, 2);
            this.btnCerrarVentan.Name = "btnCerrarVentan";
            this.btnCerrarVentan.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarVentan.TabIndex = 16;
            this.btnCerrarVentan.Click += new System.EventHandler(this.btnCerrarVentan_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 666);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblNewVittaIcon);
            this.Controls.Add(this.btnMinimizarVentan);
            this.Controls.Add(this.btnCerrarVentan);
            this.Controls.Add(this.windowBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Vitta Panel Principal";
            this.panelMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNewVittaIcon;
        private Guna.UI2.WinForms.Guna2Button btnMinimizarVentan;
        private Guna.UI2.WinForms.Guna2Button btnCerrarVentan;
        private Guna.UI2.WinForms.Guna2HtmlLabel windowBar;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Button btnInternos;
        private Guna.UI2.WinForms.Guna2Button btnDoctores;
        private Guna.UI2.WinForms.Guna2Button btnPsicologos;
        private Guna.UI2.WinForms.Guna2Button btnIngresos;
        private Guna.UI2.WinForms.Guna2Button btnEgresos;
        public System.Windows.Forms.Panel panelDynamic;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
    }
}