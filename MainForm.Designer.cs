namespace Registro
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuarioToolStripMenuItem,
            this.cargosToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.RegistroUsuarioToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargosToolStripMenuItem.Text = "Consulta";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.CargosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargosUsuariosToolStripMenuItem,
            this.consultaUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cargosUsuariosToolStripMenuItem
            // 
            this.cargosUsuariosToolStripMenuItem.Name = "cargosUsuariosToolStripMenuItem";
            this.cargosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cargosUsuariosToolStripMenuItem.Text = "Cargos Usuarios";
            this.cargosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.CargosUsuariosToolStripMenuItem_Click);
            // 
            // consultaUsuariosToolStripMenuItem
            // 
            this.consultaUsuariosToolStripMenuItem.Name = "consultaUsuariosToolStripMenuItem";
            this.consultaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaUsuariosToolStripMenuItem.Text = "Consulta Usuarios";
            this.consultaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaUsuariosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 458);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaUsuariosToolStripMenuItem;
    }
}

