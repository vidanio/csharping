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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.txtboxFolder = new System.Windows.Forms.TextBox();
            this.txtboxFiles = new System.Windows.Forms.TextBox();
            this.lblExcept = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtboxInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbarSong = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
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
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(644, 366);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 29);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtboxInfo
            // 
            this.txtboxInfo.Location = new System.Drawing.Point(31, 427);
            this.txtboxInfo.Multiline = true;
            this.txtboxInfo.Name = "txtboxInfo";
            this.txtboxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxInfo.Size = new System.Drawing.Size(710, 108);
            this.txtboxInfo.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timerShuffle_Tick);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(544, 372);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(75, 23);
            this.axWMP.TabIndex = 4;
            this.axWMP.Visible = false;
            this.axWMP.ErrorEvent += new System.EventHandler(this.axWMP_ErrorEvent);
            // 
            // pbarSong
            // 
            this.pbarSong.Location = new System.Drawing.Point(31, 411);
            this.pbarSong.Name = "pbarSong";
            this.pbarSong.Size = new System.Drawing.Size(710, 10);
            this.pbarSong.Step = 1;
            this.pbarSong.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 586);
            this.Controls.Add(this.pbarSong);
            this.Controls.Add(this.txtboxInfo);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblExcept);
            this.Controls.Add(this.txtboxFiles);
            this.Controls.Add(this.txtboxFolder);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shuffle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderOpen;
        private System.Windows.Forms.TextBox txtboxFolder;
        private System.Windows.Forms.TextBox txtboxFiles;
        private System.Windows.Forms.Label lblExcept;
        private System.Windows.Forms.Button btnShuffle;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtboxInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbarSong;
    }
}

