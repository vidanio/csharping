namespace filing
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusDown = new System.Windows.Forms.StatusStrip();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LimpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.StatusDown.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusDown
            // 
            this.StatusDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusDown.Location = new System.Drawing.Point(0, 495);
            this.StatusDown.Name = "StatusDown";
            this.StatusDown.Size = new System.Drawing.Size(755, 22);
            this.StatusDown.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(755, 24);
            this.MainMenu.TabIndex = 0;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LimpiarToolStripMenuItem,
            this.AbrirToolStripMenuItem1,
            this.GuardarToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.nuevoToolStripMenuItem.Text = "Archivo";
            // 
            // LimpiarToolStripMenuItem
            // 
            this.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem";
            this.LimpiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LimpiarToolStripMenuItem.Text = "&Limpiar";
            this.LimpiarToolStripMenuItem.Click += new System.EventHandler(this.LimpiarToolStripMenuItem_Click);
            // 
            // AbrirToolStripMenuItem1
            // 
            this.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1";
            this.AbrirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AbrirToolStripMenuItem1.Text = "A&brir fichero";
            this.AbrirToolStripMenuItem1.Click += new System.EventHandler(this.AbrirToolStripMenuItem1_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GuardarToolStripMenuItem.Text = "&Guardar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalirToolStripMenuItem.Text = "&Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBox.Location = new System.Drawing.Point(0, 24);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBox.Size = new System.Drawing.Size(755, 471);
            this.TxtBox.TabIndex = 1;
            this.TxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.Text = "(no file)";
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.Filter = "Text File|*.txt";
            // 
            // SaveFileDlg
            // 
            this.SaveFileDlg.Filter = "Text File|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 517);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.StatusDown);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filing";
            this.StatusDown.ResumeLayout(false);
            this.StatusDown.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusDown;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LimpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.SaveFileDialog SaveFileDlg;
    }
}

