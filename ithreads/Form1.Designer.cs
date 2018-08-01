namespace ithreads
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.bgHilo1 = new System.ComponentModel.BackgroundWorker();
            this.bgHilo2 = new System.ComponentModel.BackgroundWorker();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(214, 77);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(211, 149);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "label1";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgHilo1
            // 
            this.bgHilo1.WorkerReportsProgress = true;
            this.bgHilo1.WorkerSupportsCancellation = true;
            this.bgHilo1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHilo1_DoWork);
            this.bgHilo1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgHilo1_ProgressChanged);
            this.bgHilo1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHilo1_RunWorkerCompleted);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(211, 178);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label1";
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(214, 107);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 3;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 297);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnInicio);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblEstado;
        private System.ComponentModel.BackgroundWorker bgHilo1;
        private System.ComponentModel.BackgroundWorker bgHilo2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFin;
    }
}

