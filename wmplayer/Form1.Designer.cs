namespace wmplayer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileMain = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenMainSong = new System.Windows.Forms.Button();
            this.lblMainSong = new System.Windows.Forms.Label();
            this.btnPlayMainSong = new System.Windows.Forms.Button();
            this.axWMPMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbarMainVol = new System.Windows.Forms.TrackBar();
            this.txtboxStatusMain = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMediaName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEllapsed = new System.Windows.Forms.Label();
            this.progbarMainSong = new System.Windows.Forms.ProgressBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMainVol)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileMain
            // 
            this.openFileMain.Filter = "MP3 Files|*.mp3|WMA Files|*.wma|All Files|*.*";
            // 
            // btnOpenMainSong
            // 
            this.btnOpenMainSong.Location = new System.Drawing.Point(23, 22);
            this.btnOpenMainSong.Name = "btnOpenMainSong";
            this.btnOpenMainSong.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMainSong.TabIndex = 0;
            this.btnOpenMainSong.Text = "Main Song";
            this.toolTip1.SetToolTip(this.btnOpenMainSong, "Load a Song to be Played");
            this.btnOpenMainSong.UseVisualStyleBackColor = true;
            this.btnOpenMainSong.Click += new System.EventHandler(this.btnOpenMainSong_Click);
            // 
            // lblMainSong
            // 
            this.lblMainSong.AutoSize = true;
            this.lblMainSong.Location = new System.Drawing.Point(121, 31);
            this.lblMainSong.Name = "lblMainSong";
            this.lblMainSong.Size = new System.Drawing.Size(86, 13);
            this.lblMainSong.TabIndex = 1;
            this.lblMainSong.Text = "(no song loaded)";
            // 
            // btnPlayMainSong
            // 
            this.btnPlayMainSong.Location = new System.Drawing.Point(438, 98);
            this.btnPlayMainSong.Name = "btnPlayMainSong";
            this.btnPlayMainSong.Size = new System.Drawing.Size(60, 23);
            this.btnPlayMainSong.TabIndex = 2;
            this.btnPlayMainSong.Text = "Play";
            this.toolTip1.SetToolTip(this.btnPlayMainSong, "Control Playback");
            this.btnPlayMainSong.UseVisualStyleBackColor = true;
            this.btnPlayMainSong.Click += new System.EventHandler(this.btnPlayMainSong_Click);
            // 
            // axWMPMain
            // 
            this.axWMPMain.Enabled = true;
            this.axWMPMain.Location = new System.Drawing.Point(379, 21);
            this.axWMPMain.Name = "axWMPMain";
            this.axWMPMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPMain.OcxState")));
            this.axWMPMain.Size = new System.Drawing.Size(75, 23);
            this.axWMPMain.TabIndex = 3;
            this.axWMPMain.Visible = false;
            // 
            // tbarMainVol
            // 
            this.tbarMainVol.Location = new System.Drawing.Point(630, 86);
            this.tbarMainVol.Maximum = 100;
            this.tbarMainVol.Name = "tbarMainVol";
            this.tbarMainVol.Size = new System.Drawing.Size(206, 45);
            this.tbarMainVol.TabIndex = 4;
            this.tbarMainVol.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.tbarMainVol, "Set the Volume you want");
            this.tbarMainVol.Scroll += new System.EventHandler(this.tbarMainVol_Scroll);
            // 
            // txtboxStatusMain
            // 
            this.txtboxStatusMain.Location = new System.Drawing.Point(23, 86);
            this.txtboxStatusMain.Multiline = true;
            this.txtboxStatusMain.Name = "txtboxStatusMain";
            this.txtboxStatusMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxStatusMain.Size = new System.Drawing.Size(346, 157);
            this.txtboxStatusMain.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtboxStatusMain, "Shows WMP Events as they happen");
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(384, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear All Events");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMediaName
            // 
            this.lblMediaName.AutoSize = true;
            this.lblMediaName.Location = new System.Drawing.Point(435, 159);
            this.lblMediaName.Name = "lblMediaName";
            this.lblMediaName.Size = new System.Drawing.Size(48, 13);
            this.lblMediaName.TabIndex = 7;
            this.lblMediaName.Text = "(nothing)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEllapsed
            // 
            this.lblEllapsed.AutoSize = true;
            this.lblEllapsed.Location = new System.Drawing.Point(438, 191);
            this.lblEllapsed.Name = "lblEllapsed";
            this.lblEllapsed.Size = new System.Drawing.Size(33, 13);
            this.lblEllapsed.TabIndex = 8;
            this.lblEllapsed.Text = "0 sec";
            // 
            // progbarMainSong
            // 
            this.progbarMainSong.Location = new System.Drawing.Point(441, 220);
            this.progbarMainSong.Name = "progbarMainSong";
            this.progbarMainSong.Size = new System.Drawing.Size(395, 23);
            this.progbarMainSong.Step = 1;
            this.progbarMainSong.TabIndex = 9;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(504, 97);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(62, 24);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.toolTip1.SetToolTip(this.btnPause, "Control Playback");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "VOLUME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "WMP Events:";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.percent.Location = new System.Drawing.Point(627, 225);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(23, 13);
            this.percent.TabIndex = 13;
            this.percent.Text = "0%";
            this.percent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 295);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.progbarMainSong);
            this.Controls.Add(this.lblEllapsed);
            this.Controls.Add(this.lblMediaName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxStatusMain);
            this.Controls.Add(this.tbarMainVol);
            this.Controls.Add(this.axWMPMain);
            this.Controls.Add(this.btnPlayMainSong);
            this.Controls.Add(this.lblMainSong);
            this.Controls.Add(this.btnOpenMainSong);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMPMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMainVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileMain;
        private System.Windows.Forms.Button btnOpenMainSong;
        private System.Windows.Forms.Label lblMainSong;
        private System.Windows.Forms.Button btnPlayMainSong;
        private AxWMPLib.AxWindowsMediaPlayer axWMPMain;
        private System.Windows.Forms.TrackBar tbarMainVol;
        private System.Windows.Forms.TextBox txtboxStatusMain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMediaName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEllapsed;
        private System.Windows.Forms.ProgressBar progbarMainSong;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label percent;
    }
}

