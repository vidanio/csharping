namespace itwoplay
{
    partial class MainTwoPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTwoPlay));
            this.trackBarSong1 = new System.Windows.Forms.TrackBar();
            this.LblSong2 = new System.Windows.Forms.Label();
            this.LblSong1 = new System.Windows.Forms.Label();
            this.axWMPro1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWMPro2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.gprCancion2 = new System.Windows.Forms.GroupBox();
            this.trackBarSong2 = new System.Windows.Forms.TrackBar();
            this.btnSong2 = new System.Windows.Forms.Button();
            this.grpSong1 = new System.Windows.Forms.GroupBox();
            this.btnSong1 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro2)).BeginInit();
            this.gprCancion2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSong2)).BeginInit();
            this.grpSong1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarSong1
            // 
            this.trackBarSong1.AccessibleDescription = "";
            this.trackBarSong1.Location = new System.Drawing.Point(6, 80);
            this.trackBarSong1.Maximum = 100;
            this.trackBarSong1.Name = "trackBarSong1";
            this.trackBarSong1.Size = new System.Drawing.Size(400, 45);
            this.trackBarSong1.TabIndex = 2;
            this.trackBarSong1.Tag = "";
            this.trackBarSong1.TickFrequency = 10;
            this.trackBarSong1.Scroll += new System.EventHandler(this.trackBarSong1_Scroll);
            // 
            // LblSong2
            // 
            this.LblSong2.AutoSize = true;
            this.LblSong2.Location = new System.Drawing.Point(102, 35);
            this.LblSong2.Name = "LblSong2";
            this.LblSong2.Size = new System.Drawing.Size(55, 13);
            this.LblSong2.TabIndex = 3;
            this.LblSong2.Text = "Canción 2";
            // 
            // LblSong1
            // 
            this.LblSong1.AutoSize = true;
            this.LblSong1.Location = new System.Drawing.Point(102, 37);
            this.LblSong1.Name = "LblSong1";
            this.LblSong1.Size = new System.Drawing.Size(55, 13);
            this.LblSong1.TabIndex = 4;
            this.LblSong1.Text = "Canción 1";
            // 
            // axWMPro1
            // 
            this.axWMPro1.Enabled = true;
            this.axWMPro1.Location = new System.Drawing.Point(447, 18);
            this.axWMPro1.Name = "axWMPro1";
            this.axWMPro1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPro1.OcxState")));
            this.axWMPro1.Size = new System.Drawing.Size(75, 36);
            this.axWMPro1.TabIndex = 5;
            this.axWMPro1.Visible = false;
            // 
            // axWMPro2
            // 
            this.axWMPro2.Enabled = true;
            this.axWMPro2.Location = new System.Drawing.Point(447, 242);
            this.axWMPro2.Name = "axWMPro2";
            this.axWMPro2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPro2.OcxState")));
            this.axWMPro2.Size = new System.Drawing.Size(75, 33);
            this.axWMPro2.TabIndex = 6;
            this.axWMPro2.Visible = false;
            // 
            // gprCancion2
            // 
            this.gprCancion2.Controls.Add(this.trackBarSong2);
            this.gprCancion2.Controls.Add(this.btnSong2);
            this.gprCancion2.Controls.Add(this.LblSong2);
            this.gprCancion2.Location = new System.Drawing.Point(29, 151);
            this.gprCancion2.Name = "gprCancion2";
            this.gprCancion2.Size = new System.Drawing.Size(412, 124);
            this.gprCancion2.TabIndex = 7;
            this.gprCancion2.TabStop = false;
            this.gprCancion2.Text = "Cargar Canción 2";
            // 
            // trackBarSong2
            // 
            this.trackBarSong2.Location = new System.Drawing.Point(6, 73);
            this.trackBarSong2.Maximum = 100;
            this.trackBarSong2.Name = "trackBarSong2";
            this.trackBarSong2.Size = new System.Drawing.Size(400, 45);
            this.trackBarSong2.TabIndex = 4;
            this.trackBarSong2.TickFrequency = 10;
            this.trackBarSong2.Scroll += new System.EventHandler(this.trackBarSong2_Scroll);
            // 
            // btnSong2
            // 
            this.btnSong2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSong2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSong2.Location = new System.Drawing.Point(21, 30);
            this.btnSong2.Name = "btnSong2";
            this.btnSong2.Size = new System.Drawing.Size(75, 23);
            this.btnSong2.TabIndex = 0;
            this.btnSong2.Text = "Cargar";
            this.btnSong2.UseVisualStyleBackColor = false;
            this.btnSong2.Click += new System.EventHandler(this.btnSong2_Click);
            // 
            // grpSong1
            // 
            this.grpSong1.Controls.Add(this.btnSong1);
            this.grpSong1.Controls.Add(this.LblSong1);
            this.grpSong1.Controls.Add(this.trackBarSong1);
            this.grpSong1.Location = new System.Drawing.Point(29, 18);
            this.grpSong1.Name = "grpSong1";
            this.grpSong1.Size = new System.Drawing.Size(412, 127);
            this.grpSong1.TabIndex = 4;
            this.grpSong1.TabStop = false;
            this.grpSong1.Text = "Cargar Canción 1";
            // 
            // btnSong1
            // 
            this.btnSong1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSong1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSong1.Location = new System.Drawing.Point(21, 32);
            this.btnSong1.Name = "btnSong1";
            this.btnSong1.Size = new System.Drawing.Size(75, 23);
            this.btnSong1.TabIndex = 8;
            this.btnSong1.Text = "Cargar";
            this.btnSong1.UseVisualStyleBackColor = false;
            this.btnSong1.Click += new System.EventHandler(this.btnSong1_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // MainTwoPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 287);
            this.Controls.Add(this.grpSong1);
            this.Controls.Add(this.gprCancion2);
            this.Controls.Add(this.axWMPro2);
            this.Controls.Add(this.axWMPro1);
            this.MaximizeBox = false;
            this.Name = "MainTwoPlay";
            this.Text = "TwoPlay";
            this.Load += new System.EventHandler(this.MainTwoPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPro2)).EndInit();
            this.gprCancion2.ResumeLayout(false);
            this.gprCancion2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSong2)).EndInit();
            this.grpSong1.ResumeLayout(false);
            this.grpSong1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarSong1;
        private System.Windows.Forms.Label LblSong2;
        private System.Windows.Forms.Label LblSong1;
        private AxWMPLib.AxWindowsMediaPlayer axWMPro1;
        private AxWMPLib.AxWindowsMediaPlayer axWMPro2;
        private System.Windows.Forms.GroupBox gprCancion2;
        private System.Windows.Forms.Button btnSong2;
        private System.Windows.Forms.GroupBox grpSong1;
        private System.Windows.Forms.Button btnSong1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TrackBar trackBarSong2;
    }
}

