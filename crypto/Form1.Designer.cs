namespace crypto
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
            this.txtboxFolderIn = new System.Windows.Forms.TextBox();
            this.txtboxFolderOut = new System.Windows.Forms.TextBox();
            this.txtListIn = new System.Windows.Forms.TextBox();
            this.txtListOut = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.fldbrwDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtboxFolderIn
            // 
            this.txtboxFolderIn.Location = new System.Drawing.Point(58, 86);
            this.txtboxFolderIn.Name = "txtboxFolderIn";
            this.txtboxFolderIn.ReadOnly = true;
            this.txtboxFolderIn.Size = new System.Drawing.Size(452, 20);
            this.txtboxFolderIn.TabIndex = 0;
            this.txtboxFolderIn.Text = "(choose input folder)";
            this.txtboxFolderIn.Click += new System.EventHandler(this.txtboxFolderIn_Click);
            // 
            // txtboxFolderOut
            // 
            this.txtboxFolderOut.Location = new System.Drawing.Point(562, 86);
            this.txtboxFolderOut.Name = "txtboxFolderOut";
            this.txtboxFolderOut.ReadOnly = true;
            this.txtboxFolderOut.Size = new System.Drawing.Size(452, 20);
            this.txtboxFolderOut.TabIndex = 0;
            this.txtboxFolderOut.Text = "(choose output folder)";
            this.txtboxFolderOut.Click += new System.EventHandler(this.txtboxFolderOut_Click);
            // 
            // txtListIn
            // 
            this.txtListIn.Location = new System.Drawing.Point(58, 112);
            this.txtListIn.Multiline = true;
            this.txtListIn.Name = "txtListIn";
            this.txtListIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListIn.Size = new System.Drawing.Size(452, 381);
            this.txtListIn.TabIndex = 1;
            // 
            // txtListOut
            // 
            this.txtListOut.Location = new System.Drawing.Point(562, 112);
            this.txtListOut.Multiline = true;
            this.txtListOut.Name = "txtListOut";
            this.txtListOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListOut.Size = new System.Drawing.Size(452, 381);
            this.txtListOut.TabIndex = 1;
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrypt.Location = new System.Drawing.Point(461, 499);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(133, 36);
            this.btnCrypt.TabIndex = 2;
            this.btnCrypt.Text = "Crypt/Decrypt";
            this.btnCrypt.UseVisualStyleBackColor = false;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(461, 553);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 13);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "(none)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.txtListOut);
            this.Controls.Add(this.txtListIn);
            this.Controls.Add(this.txtboxFolderOut);
            this.Controls.Add(this.txtboxFolderIn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFolderIn;
        private System.Windows.Forms.TextBox txtboxFolderOut;
        private System.Windows.Forms.TextBox txtListIn;
        private System.Windows.Forms.TextBox txtListOut;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.FolderBrowserDialog fldbrwDlg;
    }
}

