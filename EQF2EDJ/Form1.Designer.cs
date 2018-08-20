namespace EQF2EDJ
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
            this.txtEQFfile = new System.Windows.Forms.TextBox();
            this.txtEDJcode = new System.Windows.Forms.TextBox();
            this.btnSaveToEDJ = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveEDJDlg = new System.Windows.Forms.SaveFileDialog();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEQFfile
            // 
            this.txtEQFfile.Location = new System.Drawing.Point(41, 49);
            this.txtEQFfile.Name = "txtEQFfile";
            this.txtEQFfile.ReadOnly = true;
            this.txtEQFfile.Size = new System.Drawing.Size(364, 20);
            this.txtEQFfile.TabIndex = 0;
            this.txtEQFfile.Text = "(choose EQF file)";
            this.txtEQFfile.Click += new System.EventHandler(this.txtEQFfile_Click);
            // 
            // txtEDJcode
            // 
            this.txtEDJcode.AllowDrop = true;
            this.txtEDJcode.Location = new System.Drawing.Point(41, 75);
            this.txtEDJcode.Multiline = true;
            this.txtEDJcode.Name = "txtEDJcode";
            this.txtEDJcode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEDJcode.Size = new System.Drawing.Size(599, 282);
            this.txtEDJcode.TabIndex = 1;
            this.txtEDJcode.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtEDJcode_DragDrop);
            this.txtEDJcode.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtEDJcode_DragEnter);
            // 
            // btnSaveToEDJ
            // 
            this.btnSaveToEDJ.Location = new System.Drawing.Point(306, 363);
            this.btnSaveToEDJ.Name = "btnSaveToEDJ";
            this.btnSaveToEDJ.Size = new System.Drawing.Size(99, 23);
            this.btnSaveToEDJ.TabIndex = 2;
            this.btnSaveToEDJ.Text = "Save to EDJ";
            this.btnSaveToEDJ.UseVisualStyleBackColor = true;
            this.btnSaveToEDJ.Click += new System.EventHandler(this.btnSaveToEDJ_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "Winamp EQF|*.eqf";
            // 
            // saveEDJDlg
            // 
            this.saveEDJDlg.Filter = "EDJ File|*.edj";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(426, 49);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(37, 13);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "(none)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 421);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnSaveToEDJ);
            this.Controls.Add(this.txtEDJcode);
            this.Controls.Add(this.txtEQFfile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQF to edj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEQFfile;
        private System.Windows.Forms.TextBox txtEDJcode;
        private System.Windows.Forms.Button btnSaveToEDJ;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveEDJDlg;
        private System.Windows.Forms.Label lblLog;
    }
}

