namespace SistemaOdonto
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.CadDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.CadPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.AgDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.AgPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadConsultas,
            this.CadDentistas,
            this.CadPacientes});
            this.cadastrosToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.add;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // CadConsultas
            // 
            this.CadConsultas.BackColor = System.Drawing.Color.White;
            this.CadConsultas.Name = "CadConsultas";
            this.CadConsultas.Size = new System.Drawing.Size(155, 26);
            this.CadConsultas.Text = "Consultas";
            this.CadConsultas.Click += new System.EventHandler(this.CadConsultas_Click);
            // 
            // CadDentistas
            // 
            this.CadDentistas.Name = "CadDentistas";
            this.CadDentistas.Size = new System.Drawing.Size(155, 26);
            this.CadDentistas.Text = "Dentistas";
            this.CadDentistas.Click += new System.EventHandler(this.CadDentistas_Click);
            // 
            // CadPacientes
            // 
            this.CadPacientes.BackColor = System.Drawing.Color.White;
            this.CadPacientes.ForeColor = System.Drawing.Color.Black;
            this.CadPacientes.Name = "CadPacientes";
            this.CadPacientes.Size = new System.Drawing.Size(155, 26);
            this.CadPacientes.Text = "Pacientes";
            this.CadPacientes.Click += new System.EventHandler(this.CadPacientes_Click);
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgConsultas,
            this.AgDentistas,
            this.AgPacientes});
            this.agendasToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.agenda;
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // AgConsultas
            // 
            this.AgConsultas.Name = "AgConsultas";
            this.AgConsultas.Size = new System.Drawing.Size(224, 26);
            this.AgConsultas.Text = "Consultas";
            // 
            // AgDentistas
            // 
            this.AgDentistas.Name = "AgDentistas";
            this.AgDentistas.Size = new System.Drawing.Size(224, 26);
            this.AgDentistas.Text = "Dentistas";
            this.AgDentistas.Click += new System.EventHandler(this.AgDentistas_Click);
            // 
            // AgPacientes
            // 
            this.AgPacientes.Name = "AgPacientes";
            this.AgPacientes.Size = new System.Drawing.Size(224, 26);
            this.AgPacientes.Text = "Pacientes";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.ajuda;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::SistemaOdonto.Properties.Resources.sair;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadConsultas;
        private System.Windows.Forms.ToolStripMenuItem CadDentistas;
        private System.Windows.Forms.ToolStripMenuItem CadPacientes;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgConsultas;
        private System.Windows.Forms.ToolStripMenuItem AgDentistas;
        private System.Windows.Forms.ToolStripMenuItem AgPacientes;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}