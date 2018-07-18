namespace ishuffle
{
    partial class MainShuffle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainShuffle));
            this.txtSelectDir = new System.Windows.Forms.TextBox();
            this.btnMezcla = new System.Windows.Forms.Button();
            this.listContentDir = new System.Windows.Forms.ListBox();
            this.abrirDirectorios = new System.Windows.Forms.FolderBrowserDialog();
            this.lblInfoError = new System.Windows.Forms.Label();
            this.axWMPro = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.playingInfo = new System.Windows.Forms.ListBox();
            this.timerShuffle = new System.Windows.Forms.Timer(this.components);
            this.progressShuffle = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSelectDir
            // 
            this.txtSelectDir.Location = new System.Drawing.Point(226, 38);
            this.txtSelectDir.Name = "txtSelectDir";
            this.txtSelectDir.Size = new System.Drawing.Size(259, 20);
            this.txtSelectDir.TabIndex = 0;
            this.txtSelectDir.Text = "<Seleccionar Directorio>";
            this.txtSelectDir.Click += new System.EventHandler(this.txtSelectDir_Click);
            // 
            // btnMezcla
            // 
            this.btnMezcla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMezcla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMezcla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMezcla.Location = new System.Drawing.Point(491, 36);
            this.btnMezcla.Name = "btnMezcla";
            this.btnMezcla.Size = new System.Drawing.Size(75, 23);
            this.btnMezcla.TabIndex = 1;
            this.btnMezcla.Text = "Mezclar";
            this.btnMezcla.UseVisualStyleBackColor = false;
            this.btnMezcla.Click += new System.EventHandler(this.btnMezcla_Click);
            // 
            // listContentDir
            // 
            this.listContentDir.FormattingEnabled = true;
            this.listContentDir.Location = new System.Drawing.Point(53, 65);
            this.listContentDir.Name = "listContentDir";
            this.listContentDir.Size = new System.Drawing.Size(643, 160);
            this.listContentDir.TabIndex = 2;
            // 
            // lblInfoError
            // 
            this.lblInfoError.AutoSize = true;
            this.lblInfoError.Location = new System.Drawing.Point(53, 232);
            this.lblInfoError.Name = "lblInfoError";
            this.lblInfoError.Size = new System.Drawing.Size(48, 13);
            this.lblInfoError.TabIndex = 3;
            this.lblInfoError.Text = "info error";
            // 
            // axWMPro
            // 
            this.axWMPro.Enabled = true;
            this.axWMPro.Location = new System.Drawing.Point(491, 232);
            this.axWMPro.Name = "axWMPro";
            this.axWMPro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPro.OcxState")));
            this.axWMPro.Size = new System.Drawing.Size(110, 35);
            this.axWMPro.TabIndex = 4;
            this.axWMPro.Visible = false;
            this.axWMPro.ErrorEvent += new System.EventHandler(this.axWMPro_ErrorEvent);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(620, 232);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Reproducir";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // playingInfo
            // 
            this.playingInfo.FormattingEnabled = true;
            this.playingInfo.Location = new System.Drawing.Point(53, 304);
            this.playingInfo.Name = "playingInfo";
            this.playingInfo.Size = new System.Drawing.Size(642, 121);
            this.playingInfo.TabIndex = 6;
            // 
            // timerShuffle
            // 
            this.timerShuffle.Interval = 500;
            this.timerShuffle.Tick += new System.EventHandler(this.timerShuffle_Tick);
            // 
            // progressShuffle
            // 
            this.progressShuffle.Location = new System.Drawing.Point(53, 285);
            this.progressShuffle.Name = "progressShuffle";
            this.progressShuffle.Size = new System.Drawing.Size(642, 13);
            this.progressShuffle.Step = 1;
            this.progressShuffle.TabIndex = 7;
            // 
            // MainShuffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.progressShuffle);
            this.Controls.Add(this.playingInfo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.axWMPro);
            this.Controls.Add(this.lblInfoError);
            this.Controls.Add(this.listContentDir);
            this.Controls.Add(this.btnMezcla);
            this.Controls.Add(this.txtSelectDir);
            this.MaximizeBox = false;
            this.Name = "MainShuffle";
            this.Text = "Shuffle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainShuffle_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectDir;
        private System.Windows.Forms.Button btnMezcla;
        private System.Windows.Forms.ListBox listContentDir;
        private System.Windows.Forms.FolderBrowserDialog abrirDirectorios;
        private System.Windows.Forms.Label lblInfoError;
        private AxWMPLib.AxWindowsMediaPlayer axWMPro;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox playingInfo;
        private System.Windows.Forms.Timer timerShuffle;
        private System.Windows.Forms.ProgressBar progressShuffle;
    }
}

