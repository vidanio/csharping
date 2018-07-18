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
            this.components = new System.ComponentModel.Container();
            this.txtEntradaEnc = new System.Windows.Forms.TextBox();
            this.DirectorioEntrada = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEncript = new System.Windows.Forms.Button();
            this.groupBoxDirs = new System.Windows.Forms.GroupBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtSalidaEnc = new System.Windows.Forms.TextBox();
            this.listadoDirectorios = new System.Windows.Forms.ListBox();
            this.comboDirs = new System.Windows.Forms.GroupBox();
            this.emptySelects = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripEnc = new System.Windows.Forms.StatusStrip();
            this.status_enc = new System.Windows.Forms.ToolStripStatusLabel();
            this.DirectorioSalida = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxDirs.SuspendLayout();
            this.comboDirs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySelects)).BeginInit();
            this.statusStripEnc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntradaEnc
            // 
            this.txtEntradaEnc.Location = new System.Drawing.Point(42, 49);
            this.txtEntradaEnc.Name = "txtEntradaEnc";
            this.txtEntradaEnc.Size = new System.Drawing.Size(263, 20);
            this.txtEntradaEnc.TabIndex = 0;
            this.txtEntradaEnc.Click += new System.EventHandler(this.txtEntradaEnc_Click);
            // 
            // btnEncript
            // 
            this.btnEncript.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncript.Location = new System.Drawing.Point(332, 97);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(75, 23);
            this.btnEncript.TabIndex = 1;
            this.btnEncript.Text = "Encriptar";
            this.btnEncript.UseVisualStyleBackColor = false;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // groupBoxDirs
            // 
            this.groupBoxDirs.Controls.Add(this.lblSalida);
            this.groupBoxDirs.Controls.Add(this.lblEntrada);
            this.groupBoxDirs.Controls.Add(this.txtSalidaEnc);
            this.groupBoxDirs.Controls.Add(this.txtEntradaEnc);
            this.groupBoxDirs.Controls.Add(this.btnEncript);
            this.groupBoxDirs.Location = new System.Drawing.Point(185, 35);
            this.groupBoxDirs.Name = "groupBoxDirs";
            this.groupBoxDirs.Size = new System.Drawing.Size(429, 145);
            this.groupBoxDirs.TabIndex = 2;
            this.groupBoxDirs.TabStop = false;
            this.groupBoxDirs.Text = "Encriptar";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(42, 81);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(99, 13);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Directorio de Salida";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(39, 33);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(107, 13);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Directorio de Entrada";
            // 
            // txtSalidaEnc
            // 
            this.txtSalidaEnc.Location = new System.Drawing.Point(42, 100);
            this.txtSalidaEnc.Name = "txtSalidaEnc";
            this.txtSalidaEnc.Size = new System.Drawing.Size(263, 20);
            this.txtSalidaEnc.TabIndex = 2;
            this.txtSalidaEnc.Click += new System.EventHandler(this.txtSalidaEnc_Click);
            // 
            // listadoDirectorios
            // 
            this.listadoDirectorios.FormattingEnabled = true;
            this.listadoDirectorios.Location = new System.Drawing.Point(40, 34);
            this.listadoDirectorios.Name = "listadoDirectorios";
            this.listadoDirectorios.Size = new System.Drawing.Size(666, 160);
            this.listadoDirectorios.TabIndex = 3;
            // 
            // comboDirs
            // 
            this.comboDirs.Controls.Add(this.listadoDirectorios);
            this.comboDirs.Location = new System.Drawing.Point(12, 186);
            this.comboDirs.Name = "comboDirs";
            this.comboDirs.Size = new System.Drawing.Size(740, 228);
            this.comboDirs.TabIndex = 4;
            this.comboDirs.TabStop = false;
            this.comboDirs.Text = "Ficheros Encriptados";
            // 
            // emptySelects
            // 
            this.emptySelects.ContainerControl = this;
            // 
            // statusStripEnc
            // 
            this.statusStripEnc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_enc});
            this.statusStripEnc.Location = new System.Drawing.Point(0, 440);
            this.statusStripEnc.Name = "statusStripEnc";
            this.statusStripEnc.Size = new System.Drawing.Size(764, 22);
            this.statusStripEnc.TabIndex = 5;
            this.statusStripEnc.Text = "statusStrip1";
            // 
            // status_enc
            // 
            this.status_enc.Name = "status_enc";
            this.status_enc.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.statusStripEnc);
            this.Controls.Add(this.comboDirs);
            this.Controls.Add(this.groupBoxDirs);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDirs.ResumeLayout(false);
            this.groupBoxDirs.PerformLayout();
            this.comboDirs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySelects)).EndInit();
            this.statusStripEnc.ResumeLayout(false);
            this.statusStripEnc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaEnc;
        private System.Windows.Forms.FolderBrowserDialog DirectorioEntrada;
        private System.Windows.Forms.Button btnEncript;
        private System.Windows.Forms.GroupBox groupBoxDirs;
        private System.Windows.Forms.ListBox listadoDirectorios;
        private System.Windows.Forms.GroupBox comboDirs;
        private System.Windows.Forms.TextBox txtSalidaEnc;
        private System.Windows.Forms.ErrorProvider emptySelects;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.StatusStrip statusStripEnc;
        private System.Windows.Forms.ToolStripStatusLabel status_enc;
        private System.Windows.Forms.FolderBrowserDialog DirectorioSalida;
    }
}

