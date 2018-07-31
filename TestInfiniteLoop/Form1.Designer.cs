namespace winforms
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
            this.bgHilo = new System.ComponentModel.BackgroundWorker();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgHilo
            // 
            this.bgHilo.WorkerReportsProgress = true;
            this.bgHilo.WorkerSupportsCancellation = true;
            this.bgHilo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHilo_DoWork);
            this.bgHilo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgHilo_ProgressChanged);
            this.bgHilo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHilo_RunWorkerCompleted);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(12, 67);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(278, 23);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(113, 115);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Start";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(113, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 271);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblCount);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infinite Loop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgHilo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnReset;
    }
}

