namespace twoplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.axWMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWMP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnLoadSong1 = new System.Windows.Forms.Button();
            this.lblSong1 = new System.Windows.Forms.Label();
            this.tbarVol1 = new System.Windows.Forms.TrackBar();
            this.lblVol1 = new System.Windows.Forms.Label();
            this.btnLoadSong2 = new System.Windows.Forms.Button();
            this.lblSong2 = new System.Windows.Forms.Label();
            this.tbarVol2 = new System.Windows.Forms.TrackBar();
            this.lblVol2 = new System.Windows.Forms.Label();
            this.openSong = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVol2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMP1
            // 
            this.axWMP1.Enabled = true;
            this.axWMP1.Location = new System.Drawing.Point(207, 12);
            this.axWMP1.Name = "axWMP1";
            this.axWMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP1.OcxState")));
            this.axWMP1.Size = new System.Drawing.Size(75, 23);
            this.axWMP1.TabIndex = 0;
            this.axWMP1.Visible = false;
            // 
            // axWMP2
            // 
            this.axWMP2.Enabled = true;
            this.axWMP2.Location = new System.Drawing.Point(207, 145);
            this.axWMP2.Name = "axWMP2";
            this.axWMP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP2.OcxState")));
            this.axWMP2.Size = new System.Drawing.Size(75, 23);
            this.axWMP2.TabIndex = 1;
            this.axWMP2.Visible = false;
            // 
            // btnLoadSong1
            // 
            this.btnLoadSong1.Location = new System.Drawing.Point(26, 11);
            this.btnLoadSong1.Name = "btnLoadSong1";
            this.btnLoadSong1.Size = new System.Drawing.Size(90, 23);
            this.btnLoadSong1.TabIndex = 2;
            this.btnLoadSong1.Text = "Load Song 1";
            this.btnLoadSong1.UseVisualStyleBackColor = true;
            this.btnLoadSong1.Click += new System.EventHandler(this.btnLoadSong1_Click);
            // 
            // lblSong1
            // 
            this.lblSong1.AutoSize = true;
            this.lblSong1.Location = new System.Drawing.Point(122, 20);
            this.lblSong1.Name = "lblSong1";
            this.lblSong1.Size = new System.Drawing.Size(60, 13);
            this.lblSong1.TabIndex = 3;
            this.lblSong1.Text = "(no song 1)";
            // 
            // tbarVol1
            // 
            this.tbarVol1.Location = new System.Drawing.Point(26, 67);
            this.tbarVol1.Maximum = 100;
            this.tbarVol1.Name = "tbarVol1";
            this.tbarVol1.Size = new System.Drawing.Size(256, 45);
            this.tbarVol1.TabIndex = 4;
            this.tbarVol1.TickFrequency = 10;
            this.tbarVol1.Scroll += new System.EventHandler(this.tbarVol1_Scroll);
            // 
            // lblVol1
            // 
            this.lblVol1.AutoSize = true;
            this.lblVol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol1.Location = new System.Drawing.Point(125, 48);
            this.lblVol1.Name = "lblVol1";
            this.lblVol1.Size = new System.Drawing.Size(59, 13);
            this.lblVol1.TabIndex = 5;
            this.lblVol1.Text = "Volume 1";
            // 
            // btnLoadSong2
            // 
            this.btnLoadSong2.Location = new System.Drawing.Point(26, 145);
            this.btnLoadSong2.Name = "btnLoadSong2";
            this.btnLoadSong2.Size = new System.Drawing.Size(90, 23);
            this.btnLoadSong2.TabIndex = 2;
            this.btnLoadSong2.Text = "Load Song 2";
            this.btnLoadSong2.UseVisualStyleBackColor = true;
            this.btnLoadSong2.Click += new System.EventHandler(this.btnLoadSong2_Click);
            // 
            // lblSong2
            // 
            this.lblSong2.AutoSize = true;
            this.lblSong2.Location = new System.Drawing.Point(122, 154);
            this.lblSong2.Name = "lblSong2";
            this.lblSong2.Size = new System.Drawing.Size(60, 13);
            this.lblSong2.TabIndex = 3;
            this.lblSong2.Text = "(no song 2)";
            // 
            // tbarVol2
            // 
            this.tbarVol2.Location = new System.Drawing.Point(26, 201);
            this.tbarVol2.Maximum = 100;
            this.tbarVol2.Name = "tbarVol2";
            this.tbarVol2.Size = new System.Drawing.Size(256, 45);
            this.tbarVol2.TabIndex = 4;
            this.tbarVol2.TickFrequency = 10;
            this.tbarVol2.Scroll += new System.EventHandler(this.tbarVol2_Scroll);
            // 
            // lblVol2
            // 
            this.lblVol2.AutoSize = true;
            this.lblVol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol2.Location = new System.Drawing.Point(125, 182);
            this.lblVol2.Name = "lblVol2";
            this.lblVol2.Size = new System.Drawing.Size(59, 13);
            this.lblVol2.TabIndex = 5;
            this.lblVol2.Text = "Volume 2";
            // 
            // openSong
            // 
            this.openSong.Filter = "MP3 Files|*.mp3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 306);
            this.Controls.Add(this.lblVol2);
            this.Controls.Add(this.lblVol1);
            this.Controls.Add(this.tbarVol2);
            this.Controls.Add(this.lblSong2);
            this.Controls.Add(this.tbarVol1);
            this.Controls.Add(this.btnLoadSong2);
            this.Controls.Add(this.lblSong1);
            this.Controls.Add(this.btnLoadSong1);
            this.Controls.Add(this.axWMP2);
            this.Controls.Add(this.axWMP1);
            this.Name = "MainForm";
            this.Text = "TwoPlay";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVol2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP1;
        private AxWMPLib.AxWindowsMediaPlayer axWMP2;
        private System.Windows.Forms.Button btnLoadSong1;
        private System.Windows.Forms.Label lblSong1;
        private System.Windows.Forms.TrackBar tbarVol1;
        private System.Windows.Forms.Label lblVol1;
        private System.Windows.Forms.Button btnLoadSong2;
        private System.Windows.Forms.Label lblSong2;
        private System.Windows.Forms.TrackBar tbarVol2;
        private System.Windows.Forms.Label lblVol2;
        private System.Windows.Forms.OpenFileDialog openSong;
    }
}

