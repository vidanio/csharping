namespace FullBackgroundWorker
{
    partial class FibonacciForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.resultLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.cancelAsyncButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(109, 13);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(160, 23);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "(no result)";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 8);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 2;
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.Location = new System.Drawing.Point(12, 63);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(120, 23);
            this.startAsyncButton.TabIndex = 1;
            this.startAsyncButton.Text = "Start Calculation";
            this.startAsyncButton.UseVisualStyleBackColor = true;
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsyncButton
            // 
            this.cancelAsyncButton.Location = new System.Drawing.Point(149, 63);
            this.cancelAsyncButton.Name = "cancelAsyncButton";
            this.cancelAsyncButton.Size = new System.Drawing.Size(120, 23);
            this.cancelAsyncButton.TabIndex = 2;
            this.cancelAsyncButton.Text = "Cancel Calculation";
            this.cancelAsyncButton.UseVisualStyleBackColor = true;
            this.cancelAsyncButton.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 131);
            this.Controls.Add(this.cancelAsyncButton);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "FibonacciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.Button cancelAsyncButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

