namespace shuffle
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
            this.folderOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.txtboxFolder = new System.Windows.Forms.TextBox();
            this.txtboxFiles = new System.Windows.Forms.TextBox();
            this.lblExcept = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxFolder
            // 
            this.txtboxFolder.Location = new System.Drawing.Point(28, 21);
            this.txtboxFolder.Name = "txtboxFolder";
            this.txtboxFolder.ReadOnly = true;
            this.txtboxFolder.Size = new System.Drawing.Size(278, 20);
            this.txtboxFolder.TabIndex = 0;
            this.txtboxFolder.Text = "(Get Folder)";
            this.txtboxFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtboxFolder_MouseClick);
            // 
            // txtboxFiles
            // 
            this.txtboxFiles.Location = new System.Drawing.Point(28, 47);
            this.txtboxFiles.Multiline = true;
            this.txtboxFiles.Name = "txtboxFiles";
            this.txtboxFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxFiles.Size = new System.Drawing.Size(713, 313);
            this.txtboxFiles.TabIndex = 1;
            // 
            // lblExcept
            // 
            this.lblExcept.AutoSize = true;
            this.lblExcept.Location = new System.Drawing.Point(28, 367);
            this.lblExcept.Name = "lblExcept";
            this.lblExcept.Size = new System.Drawing.Size(35, 13);
            this.lblExcept.TabIndex = 2;
            this.lblExcept.Text = "label1";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShuffle.Location = new System.Drawing.Point(344, 20);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(79, 21);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblExcept);
            this.Controls.Add(this.txtboxFiles);
            this.Controls.Add(this.txtboxFolder);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shuffle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderOpen;
        private System.Windows.Forms.TextBox txtboxFolder;
        private System.Windows.Forms.TextBox txtboxFiles;
        private System.Windows.Forms.Label lblExcept;
        private System.Windows.Forms.Button btnShuffle;
    }
}

