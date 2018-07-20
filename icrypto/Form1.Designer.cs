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
            this.groupBoxRutas = new System.Windows.Forms.GroupBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtSalidaEnc = new System.Windows.Forms.TextBox();
            this.emptySelects = new System.Windows.Forms.ErrorProvider(this.components);
            this.DirectorioSalida = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.radioDecript = new System.Windows.Forms.RadioButton();
            this.radioEncript = new System.Windows.Forms.RadioButton();
            this.ficherosParaEncriptar = new System.Windows.Forms.ListBox();
            this.ficherosEncriptados = new System.Windows.Forms.ListBox();
            this.lblcontainer1 = new System.Windows.Forms.Label();
            this.lblcontainer2 = new System.Windows.Forms.Label();
            this.lblInfoCrypt = new System.Windows.Forms.Label();
            this.groupBoxRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySelects)).BeginInit();
            this.groupBoxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntradaEnc
            // 
            this.txtEntradaEnc.Location = new System.Drawing.Point(22, 42);
            this.txtEntradaEnc.Name = "txtEntradaEnc";
            this.txtEntradaEnc.Size = new System.Drawing.Size(423, 20);
            this.txtEntradaEnc.TabIndex = 0;
            this.txtEntradaEnc.Click += new System.EventHandler(this.txtEntradaEnc_Click);
            // 
            // btnEncript
            // 
            this.btnEncript.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncript.Location = new System.Drawing.Point(209, 115);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(85, 23);
            this.btnEncript.TabIndex = 1;
            this.btnEncript.Text = "Encriptar";
            this.btnEncript.UseVisualStyleBackColor = false;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // groupBoxRutas
            // 
            this.groupBoxRutas.Controls.Add(this.lblSalida);
            this.groupBoxRutas.Controls.Add(this.lblEntrada);
            this.groupBoxRutas.Controls.Add(this.btnEncript);
            this.groupBoxRutas.Controls.Add(this.txtSalidaEnc);
            this.groupBoxRutas.Controls.Add(this.txtEntradaEnc);
            this.groupBoxRutas.Location = new System.Drawing.Point(274, 35);
            this.groupBoxRutas.Name = "groupBoxRutas";
            this.groupBoxRutas.Size = new System.Drawing.Size(472, 152);
            this.groupBoxRutas.TabIndex = 2;
            this.groupBoxRutas.TabStop = false;
            this.groupBoxRutas.Text = "Rutas";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(19, 65);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(99, 13);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Directorio de Salida";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(19, 26);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(107, 13);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Directorio de Entrada";
            // 
            // txtSalidaEnc
            // 
            this.txtSalidaEnc.Location = new System.Drawing.Point(22, 89);
            this.txtSalidaEnc.Name = "txtSalidaEnc";
            this.txtSalidaEnc.Size = new System.Drawing.Size(423, 20);
            this.txtSalidaEnc.TabIndex = 2;
            this.txtSalidaEnc.Click += new System.EventHandler(this.txtSalidaEnc_Click);
            // 
            // emptySelects
            // 
            this.emptySelects.ContainerControl = this;
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.radioDecript);
            this.groupBoxOpciones.Controls.Add(this.radioEncript);
            this.groupBoxOpciones.Location = new System.Drawing.Point(52, 35);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(216, 152);
            this.groupBoxOpciones.TabIndex = 6;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opciones";
            // 
            // radioDecript
            // 
            this.radioDecript.AutoSize = true;
            this.radioDecript.Location = new System.Drawing.Point(59, 89);
            this.radioDecript.Name = "radioDecript";
            this.radioDecript.Size = new System.Drawing.Size(85, 17);
            this.radioDecript.TabIndex = 1;
            this.radioDecript.Text = "Desencriptar";
            this.radioDecript.UseVisualStyleBackColor = true;
            this.radioDecript.CheckedChanged += new System.EventHandler(this.radioDecript_CheckedChanged);
            // 
            // radioEncript
            // 
            this.radioEncript.AutoSize = true;
            this.radioEncript.Location = new System.Drawing.Point(59, 45);
            this.radioEncript.Name = "radioEncript";
            this.radioEncript.Size = new System.Drawing.Size(67, 17);
            this.radioEncript.TabIndex = 0;
            this.radioEncript.Text = "Encriptar";
            this.radioEncript.UseVisualStyleBackColor = true;
            this.radioEncript.CheckedChanged += new System.EventHandler(this.radioEncript_CheckedChanged);
            // 
            // ficherosParaEncriptar
            // 
            this.ficherosParaEncriptar.FormattingEnabled = true;
            this.ficherosParaEncriptar.Location = new System.Drawing.Point(24, 225);
            this.ficherosParaEncriptar.Name = "ficherosParaEncriptar";
            this.ficherosParaEncriptar.Size = new System.Drawing.Size(358, 199);
            this.ficherosParaEncriptar.TabIndex = 3;
            // 
            // ficherosEncriptados
            // 
            this.ficherosEncriptados.FormattingEnabled = true;
            this.ficherosEncriptados.Location = new System.Drawing.Point(388, 225);
            this.ficherosEncriptados.Name = "ficherosEncriptados";
            this.ficherosEncriptados.Size = new System.Drawing.Size(364, 199);
            this.ficherosEncriptados.TabIndex = 4;
            // 
            // lblcontainer1
            // 
            this.lblcontainer1.AutoSize = true;
            this.lblcontainer1.Location = new System.Drawing.Point(24, 206);
            this.lblcontainer1.Name = "lblcontainer1";
            this.lblcontainer1.Size = new System.Drawing.Size(99, 13);
            this.lblcontainer1.TabIndex = 7;
            this.lblcontainer1.Text = "Listado de Ficheros";
            // 
            // lblcontainer2
            // 
            this.lblcontainer2.AutoSize = true;
            this.lblcontainer2.Location = new System.Drawing.Point(388, 206);
            this.lblcontainer2.Name = "lblcontainer2";
            this.lblcontainer2.Size = new System.Drawing.Size(88, 13);
            this.lblcontainer2.TabIndex = 8;
            this.lblcontainer2.Text = "Ficheros Cifrados";
            // 
            // lblInfoCrypt
            // 
            this.lblInfoCrypt.AutoSize = true;
            this.lblInfoCrypt.Location = new System.Drawing.Point(275, 435);
            this.lblInfoCrypt.Name = "lblInfoCrypt";
            this.lblInfoCrypt.Size = new System.Drawing.Size(61, 13);
            this.lblInfoCrypt.TabIndex = 9;
            this.lblInfoCrypt.Text = "informacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.lblInfoCrypt);
            this.Controls.Add(this.lblcontainer2);
            this.Controls.Add(this.lblcontainer1);
            this.Controls.Add(this.ficherosEncriptados);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.ficherosParaEncriptar);
            this.Controls.Add(this.groupBoxRutas);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRutas.ResumeLayout(false);
            this.groupBoxRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySelects)).EndInit();
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaEnc;
        private System.Windows.Forms.FolderBrowserDialog DirectorioEntrada;
        private System.Windows.Forms.Button btnEncript;
        private System.Windows.Forms.GroupBox groupBoxRutas;
        private System.Windows.Forms.TextBox txtSalidaEnc;
        private System.Windows.Forms.ErrorProvider emptySelects;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.FolderBrowserDialog DirectorioSalida;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.RadioButton radioDecript;
        private System.Windows.Forms.RadioButton radioEncript;
        private System.Windows.Forms.Label lblcontainer2;
        private System.Windows.Forms.Label lblcontainer1;
        private System.Windows.Forms.ListBox ficherosEncriptados;
        private System.Windows.Forms.ListBox ficherosParaEncriptar;
        private System.Windows.Forms.Label lblInfoCrypt;
    }
}

