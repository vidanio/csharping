namespace Test2BackgroundWorkers
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.bgHilo1 = new System.ComponentModel.BackgroundWorker();
            this.bgHilo2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(78, 131);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(100, 66);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "0";
            // 
            // bgHilo1
            // 
            this.bgHilo1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHilo1_DoWork);
            this.bgHilo1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHilo1_RunWorkerCompleted);
            // 
            // bgHilo2
            // 
            this.bgHilo2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHilo2_DoWork);
            this.bgHilo2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHilo2_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 272);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test 2 BgWorkers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCounter;
        private System.ComponentModel.BackgroundWorker bgHilo1;
        private System.ComponentModel.BackgroundWorker bgHilo2;
    }
}

