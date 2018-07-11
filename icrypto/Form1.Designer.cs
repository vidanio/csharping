namespace icrypto
{
    partial class Form1
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
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.selectDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEncript = new System.Windows.Forms.Button();
            this.groupBoxDirs = new System.Windows.Forms.GroupBox();
            this.listadoDirectorios = new System.Windows.Forms.ListBox();
            this.comboDirs = new System.Windows.Forms.GroupBox();
            this.st_encriptado = new System.Windows.Forms.Label();
            this.groupBoxDirs.SuspendLayout();
            this.comboDirs.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(48, 38);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(263, 20);
            this.textBoxDirectory.TabIndex = 0;
            this.textBoxDirectory.Click += new System.EventHandler(this.textBoxDirectory_Click);
            // 
            // btnEncript
            // 
            this.btnEncript.Location = new System.Drawing.Point(317, 36);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(75, 23);
            this.btnEncript.TabIndex = 1;
            this.btnEncript.Text = "Encriptar";
            this.btnEncript.UseVisualStyleBackColor = true;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // groupBoxDirs
            // 
            this.groupBoxDirs.Controls.Add(this.textBoxDirectory);
            this.groupBoxDirs.Controls.Add(this.btnEncript);
            this.groupBoxDirs.Location = new System.Drawing.Point(185, 43);
            this.groupBoxDirs.Name = "groupBoxDirs";
            this.groupBoxDirs.Size = new System.Drawing.Size(429, 87);
            this.groupBoxDirs.TabIndex = 2;
            this.groupBoxDirs.TabStop = false;
            this.groupBoxDirs.Text = "Directorio para encriptar";
            // 
            // listadoDirectorios
            // 
            this.listadoDirectorios.FormattingEnabled = true;
            this.listadoDirectorios.Location = new System.Drawing.Point(40, 34);
            this.listadoDirectorios.Name = "listadoDirectorios";
            this.listadoDirectorios.Size = new System.Drawing.Size(714, 160);
            this.listadoDirectorios.TabIndex = 3;
            // 
            // comboDirs
            // 
            this.comboDirs.Controls.Add(this.listadoDirectorios);
            this.comboDirs.Location = new System.Drawing.Point(12, 136);
            this.comboDirs.Name = "comboDirs";
            this.comboDirs.Size = new System.Drawing.Size(776, 215);
            this.comboDirs.TabIndex = 4;
            this.comboDirs.TabStop = false;
            this.comboDirs.Text = "Ficheros Encriptados";
            // 
            // st_encriptado
            // 
            this.st_encriptado.AutoSize = true;
            this.st_encriptado.Location = new System.Drawing.Point(52, 368);
            this.st_encriptado.Name = "st_encriptado";
            this.st_encriptado.Size = new System.Drawing.Size(0, 13);
            this.st_encriptado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.st_encriptado);
            this.Controls.Add(this.comboDirs);
            this.Controls.Add(this.groupBoxDirs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDirs.ResumeLayout(false);
            this.groupBoxDirs.PerformLayout();
            this.comboDirs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.FolderBrowserDialog selectDirectory;
        private System.Windows.Forms.Button btnEncript;
        private System.Windows.Forms.GroupBox groupBoxDirs;
        private System.Windows.Forms.ListBox listadoDirectorios;
        private System.Windows.Forms.GroupBox comboDirs;
        private System.Windows.Forms.Label st_encriptado;
    }
}

