namespace Ecualizador
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
            this.audioDjStudio1 = new AudioDjStudio.AudioDjStudio();
            this.lblMeterLeft = new System.Windows.Forms.Label();
            this.lblMeterRight = new System.Windows.Forms.Label();
            this.tbarVolumen = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbar80 = new System.Windows.Forms.TrackBar();
            this.lbl80 = new System.Windows.Forms.Label();
            this.tbar170 = new System.Windows.Forms.TrackBar();
            this.lbl170 = new System.Windows.Forms.Label();
            this.tbar310 = new System.Windows.Forms.TrackBar();
            this.lbl310 = new System.Windows.Forms.Label();
            this.tbar600 = new System.Windows.Forms.TrackBar();
            this.lbl600 = new System.Windows.Forms.Label();
            this.tbar1k = new System.Windows.Forms.TrackBar();
            this.lbl1k = new System.Windows.Forms.Label();
            this.tbar3k = new System.Windows.Forms.TrackBar();
            this.lbl3k = new System.Windows.Forms.Label();
            this.tbar6k = new System.Windows.Forms.TrackBar();
            this.lbl6k = new System.Windows.Forms.Label();
            this.tbar12k = new System.Windows.Forms.TrackBar();
            this.lbl12k = new System.Windows.Forms.Label();
            this.tbar14k = new System.Windows.Forms.TrackBar();
            this.lbl14k = new System.Windows.Forms.Label();
            this.tbar16k = new System.Windows.Forms.TrackBar();
            this.lbl16k = new System.Windows.Forms.Label();
            this.lblMas = new System.Windows.Forms.Label();
            this.lblMenos = new System.Windows.Forms.Label();
            this.cboxWinampPresets = new System.Windows.Forms.ComboBox();
            this.lblWinampPresets = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.btnLoadEDJ = new System.Windows.Forms.Button();
            this.btnSaveEQSettings = new System.Windows.Forms.Button();
            this.btnResetEQ = new System.Windows.Forms.Button();
            this.chkboxAutoEQ = new System.Windows.Forms.CheckBox();
            this.chkboxEQOn = new System.Windows.Forms.CheckBox();
            this.chkboxNormal = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar170)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar310)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar600)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar3k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar6k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar12k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar14k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar16k)).BeginInit();
            this.SuspendLayout();
            // 
            // audioDjStudio1
            // 
            this.audioDjStudio1.FaderSettings = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.audioDjStudio1.LastError = AudioDjStudio.enumErrorCodes.ERR_NOERROR;
            this.audioDjStudio1.Location = new System.Drawing.Point(608, 12);
            this.audioDjStudio1.Name = "audioDjStudio1";
            this.audioDjStudio1.Size = new System.Drawing.Size(48, 48);
            this.audioDjStudio1.TabIndex = 0;
            this.audioDjStudio1.VUMeterValueChange += new AudioDjStudio.AudioDjStudio.VUMeterValueChangeEventHandler(this.audioDjStudio1_VUMeterValueChange);
            this.audioDjStudio1.EqualizerLoaded += new AudioDjStudio.AudioDjStudio.PlayerEventHandler(this.audioDjStudio1_EqualizerLoaded);
            // 
            // lblMeterLeft
            // 
            this.lblMeterLeft.BackColor = System.Drawing.Color.Black;
            this.lblMeterLeft.Location = new System.Drawing.Point(80, 84);
            this.lblMeterLeft.Name = "lblMeterLeft";
            this.lblMeterLeft.Size = new System.Drawing.Size(12, 140);
            this.lblMeterLeft.TabIndex = 1;
            // 
            // lblMeterRight
            // 
            this.lblMeterRight.BackColor = System.Drawing.Color.Black;
            this.lblMeterRight.Location = new System.Drawing.Point(92, 84);
            this.lblMeterRight.Name = "lblMeterRight";
            this.lblMeterRight.Size = new System.Drawing.Size(12, 140);
            this.lblMeterRight.TabIndex = 1;
            // 
            // tbarVolumen
            // 
            this.tbarVolumen.Location = new System.Drawing.Point(12, 100);
            this.tbarVolumen.Maximum = 100;
            this.tbarVolumen.Name = "tbarVolumen";
            this.tbarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarVolumen.Size = new System.Drawing.Size(45, 133);
            this.tbarVolumen.TabIndex = 2;
            this.tbarVolumen.TickFrequency = 10;
            this.tbarVolumen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarVolumen.Value = 100;
            this.tbarVolumen.Scroll += new System.EventHandler(this.tbarVolumen_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(12, 84);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 13);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "Volumen";
            // 
            // tbar80
            // 
            this.tbar80.Location = new System.Drawing.Point(148, 100);
            this.tbar80.Maximum = 1500;
            this.tbar80.Minimum = -1500;
            this.tbar80.Name = "tbar80";
            this.tbar80.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar80.Size = new System.Drawing.Size(45, 133);
            this.tbar80.TabIndex = 4;
            this.tbar80.TickFrequency = 150;
            this.tbar80.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar80.Scroll += new System.EventHandler(this.tbar80_Scroll);
            // 
            // lbl80
            // 
            this.lbl80.AutoSize = true;
            this.lbl80.Location = new System.Drawing.Point(155, 84);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(38, 13);
            this.lbl80.TabIndex = 5;
            this.lbl80.Text = "80 Hz ";
            // 
            // tbar170
            // 
            this.tbar170.Location = new System.Drawing.Point(199, 100);
            this.tbar170.Maximum = 1500;
            this.tbar170.Minimum = -1500;
            this.tbar170.Name = "tbar170";
            this.tbar170.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar170.Size = new System.Drawing.Size(45, 133);
            this.tbar170.TabIndex = 4;
            this.tbar170.TickFrequency = 150;
            this.tbar170.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar170.Scroll += new System.EventHandler(this.tbar170_Scroll);
            // 
            // lbl170
            // 
            this.lbl170.AutoSize = true;
            this.lbl170.Location = new System.Drawing.Point(203, 84);
            this.lbl170.Name = "lbl170";
            this.lbl170.Size = new System.Drawing.Size(41, 13);
            this.lbl170.TabIndex = 5;
            this.lbl170.Text = "170 Hz";
            // 
            // tbar310
            // 
            this.tbar310.Location = new System.Drawing.Point(250, 100);
            this.tbar310.Maximum = 1500;
            this.tbar310.Minimum = -1500;
            this.tbar310.Name = "tbar310";
            this.tbar310.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar310.Size = new System.Drawing.Size(45, 133);
            this.tbar310.TabIndex = 4;
            this.tbar310.TickFrequency = 150;
            this.tbar310.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar310.Scroll += new System.EventHandler(this.tbar310_Scroll);
            // 
            // lbl310
            // 
            this.lbl310.AutoSize = true;
            this.lbl310.Location = new System.Drawing.Point(251, 84);
            this.lbl310.Name = "lbl310";
            this.lbl310.Size = new System.Drawing.Size(44, 13);
            this.lbl310.TabIndex = 5;
            this.lbl310.Text = "310 Hz ";
            // 
            // tbar600
            // 
            this.tbar600.Location = new System.Drawing.Point(301, 100);
            this.tbar600.Maximum = 1500;
            this.tbar600.Minimum = -1500;
            this.tbar600.Name = "tbar600";
            this.tbar600.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar600.Size = new System.Drawing.Size(45, 133);
            this.tbar600.TabIndex = 4;
            this.tbar600.TickFrequency = 150;
            this.tbar600.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar600.Scroll += new System.EventHandler(this.tbar600_Scroll);
            // 
            // lbl600
            // 
            this.lbl600.AutoSize = true;
            this.lbl600.Location = new System.Drawing.Point(305, 84);
            this.lbl600.Name = "lbl600";
            this.lbl600.Size = new System.Drawing.Size(41, 13);
            this.lbl600.TabIndex = 5;
            this.lbl600.Text = "600 Hz";
            // 
            // tbar1k
            // 
            this.tbar1k.Location = new System.Drawing.Point(352, 100);
            this.tbar1k.Maximum = 1500;
            this.tbar1k.Minimum = -1500;
            this.tbar1k.Name = "tbar1k";
            this.tbar1k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar1k.Size = new System.Drawing.Size(45, 133);
            this.tbar1k.TabIndex = 4;
            this.tbar1k.TickFrequency = 150;
            this.tbar1k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar1k.Scroll += new System.EventHandler(this.tbar1k_Scroll);
            // 
            // lbl1k
            // 
            this.lbl1k.AutoSize = true;
            this.lbl1k.Location = new System.Drawing.Point(352, 84);
            this.lbl1k.Name = "lbl1k";
            this.lbl1k.Size = new System.Drawing.Size(35, 13);
            this.lbl1k.TabIndex = 5;
            this.lbl1k.Text = "1 kHz";
            // 
            // tbar3k
            // 
            this.tbar3k.Location = new System.Drawing.Point(403, 100);
            this.tbar3k.Maximum = 1500;
            this.tbar3k.Minimum = -1500;
            this.tbar3k.Name = "tbar3k";
            this.tbar3k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar3k.Size = new System.Drawing.Size(45, 133);
            this.tbar3k.TabIndex = 4;
            this.tbar3k.TickFrequency = 150;
            this.tbar3k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar3k.Scroll += new System.EventHandler(this.tbar3k_Scroll);
            // 
            // lbl3k
            // 
            this.lbl3k.AutoSize = true;
            this.lbl3k.Location = new System.Drawing.Point(400, 84);
            this.lbl3k.Name = "lbl3k";
            this.lbl3k.Size = new System.Drawing.Size(35, 13);
            this.lbl3k.TabIndex = 5;
            this.lbl3k.Text = "3 kHz";
            // 
            // tbar6k
            // 
            this.tbar6k.Location = new System.Drawing.Point(454, 100);
            this.tbar6k.Maximum = 1500;
            this.tbar6k.Minimum = -1500;
            this.tbar6k.Name = "tbar6k";
            this.tbar6k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar6k.Size = new System.Drawing.Size(45, 133);
            this.tbar6k.TabIndex = 4;
            this.tbar6k.TickFrequency = 150;
            this.tbar6k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar6k.Scroll += new System.EventHandler(this.tbar6k_Scroll);
            // 
            // lbl6k
            // 
            this.lbl6k.AutoSize = true;
            this.lbl6k.Location = new System.Drawing.Point(451, 84);
            this.lbl6k.Name = "lbl6k";
            this.lbl6k.Size = new System.Drawing.Size(35, 13);
            this.lbl6k.TabIndex = 5;
            this.lbl6k.Text = "6 kHz";
            // 
            // tbar12k
            // 
            this.tbar12k.Location = new System.Drawing.Point(505, 100);
            this.tbar12k.Maximum = 1500;
            this.tbar12k.Minimum = -1500;
            this.tbar12k.Name = "tbar12k";
            this.tbar12k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar12k.Size = new System.Drawing.Size(45, 133);
            this.tbar12k.TabIndex = 4;
            this.tbar12k.TickFrequency = 150;
            this.tbar12k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar12k.Scroll += new System.EventHandler(this.tbar12k_Scroll);
            // 
            // lbl12k
            // 
            this.lbl12k.AutoSize = true;
            this.lbl12k.Location = new System.Drawing.Point(502, 84);
            this.lbl12k.Name = "lbl12k";
            this.lbl12k.Size = new System.Drawing.Size(41, 13);
            this.lbl12k.TabIndex = 5;
            this.lbl12k.Text = "12 kHz";
            // 
            // tbar14k
            // 
            this.tbar14k.Location = new System.Drawing.Point(556, 100);
            this.tbar14k.Maximum = 1500;
            this.tbar14k.Minimum = -1500;
            this.tbar14k.Name = "tbar14k";
            this.tbar14k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar14k.Size = new System.Drawing.Size(45, 133);
            this.tbar14k.TabIndex = 4;
            this.tbar14k.TickFrequency = 150;
            this.tbar14k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar14k.Scroll += new System.EventHandler(this.tbar14k_Scroll);
            // 
            // lbl14k
            // 
            this.lbl14k.AutoSize = true;
            this.lbl14k.Location = new System.Drawing.Point(553, 84);
            this.lbl14k.Name = "lbl14k";
            this.lbl14k.Size = new System.Drawing.Size(41, 13);
            this.lbl14k.TabIndex = 5;
            this.lbl14k.Text = "14 kHz";
            // 
            // tbar16k
            // 
            this.tbar16k.Location = new System.Drawing.Point(607, 100);
            this.tbar16k.Maximum = 1500;
            this.tbar16k.Minimum = -1500;
            this.tbar16k.Name = "tbar16k";
            this.tbar16k.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar16k.Size = new System.Drawing.Size(45, 133);
            this.tbar16k.TabIndex = 4;
            this.tbar16k.TickFrequency = 150;
            this.tbar16k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbar16k.Scroll += new System.EventHandler(this.tbar16k_Scroll);
            // 
            // lbl16k
            // 
            this.lbl16k.AutoSize = true;
            this.lbl16k.Location = new System.Drawing.Point(605, 84);
            this.lbl16k.Name = "lbl16k";
            this.lbl16k.Size = new System.Drawing.Size(41, 13);
            this.lbl16k.TabIndex = 5;
            this.lbl16k.Text = "16 kHz";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(129, 100);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 6;
            this.lblMas.Text = "+";
            // 
            // lblMenos
            // 
            this.lblMenos.AutoSize = true;
            this.lblMenos.Location = new System.Drawing.Point(129, 211);
            this.lblMenos.Name = "lblMenos";
            this.lblMenos.Size = new System.Drawing.Size(13, 13);
            this.lblMenos.TabIndex = 6;
            this.lblMenos.Text = "_";
            // 
            // cboxWinampPresets
            // 
            this.cboxWinampPresets.FormattingEnabled = true;
            this.cboxWinampPresets.Items.AddRange(new object[] {
            "None",
            "Classical",
            "Club",
            "Dance",
            "Full Bass",
            "Full Bass Treble",
            "Full Treble",
            "Laptop Speakers",
            "Large Hall",
            "Live",
            "Party",
            "Pop",
            "Reggae",
            "Rock",
            "Ska",
            "Soft",
            "Soft Rock",
            "Techno"});
            this.cboxWinampPresets.Location = new System.Drawing.Point(15, 285);
            this.cboxWinampPresets.Name = "cboxWinampPresets";
            this.cboxWinampPresets.Size = new System.Drawing.Size(160, 21);
            this.cboxWinampPresets.TabIndex = 7;
            this.cboxWinampPresets.SelectedIndexChanged += new System.EventHandler(this.cboxWinampPresets_SelectedIndexChanged);
            // 
            // lblWinampPresets
            // 
            this.lblWinampPresets.AutoSize = true;
            this.lblWinampPresets.Location = new System.Drawing.Point(40, 269);
            this.lblWinampPresets.Name = "lblWinampPresets";
            this.lblWinampPresets.Size = new System.Drawing.Size(112, 13);
            this.lblWinampPresets.TabIndex = 8;
            this.lblWinampPresets.Text = "Winamp (TM) Presets:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(100, 36);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(181, 36);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(262, 36);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(352, 41);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(71, 13);
            this.lblSampleRate.TabIndex = 10;
            this.lblSampleRate.Text = "Sample Rate:";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(12, 17);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(37, 13);
            this.lblSong.TabIndex = 11;
            this.lblSong.Text = "(none)";
            // 
            // btnLoadEDJ
            // 
            this.btnLoadEDJ.Location = new System.Drawing.Point(199, 240);
            this.btnLoadEDJ.Name = "btnLoadEDJ";
            this.btnLoadEDJ.Size = new System.Drawing.Size(131, 23);
            this.btnLoadEDJ.TabIndex = 12;
            this.btnLoadEDJ.Text = "Load EQ File";
            this.btnLoadEDJ.UseVisualStyleBackColor = true;
            this.btnLoadEDJ.Click += new System.EventHandler(this.btnLoadEDJ_Click);
            // 
            // btnSaveEQSettings
            // 
            this.btnSaveEQSettings.Location = new System.Drawing.Point(355, 240);
            this.btnSaveEQSettings.Name = "btnSaveEQSettings";
            this.btnSaveEQSettings.Size = new System.Drawing.Size(131, 23);
            this.btnSaveEQSettings.TabIndex = 12;
            this.btnSaveEQSettings.Text = "Save EQ Settings";
            this.btnSaveEQSettings.UseVisualStyleBackColor = true;
            this.btnSaveEQSettings.Click += new System.EventHandler(this.btnSaveEQSettings_Click);
            // 
            // btnResetEQ
            // 
            this.btnResetEQ.Location = new System.Drawing.Point(515, 240);
            this.btnResetEQ.Name = "btnResetEQ";
            this.btnResetEQ.Size = new System.Drawing.Size(131, 23);
            this.btnResetEQ.TabIndex = 12;
            this.btnResetEQ.Text = "Reset EQ Values";
            this.btnResetEQ.UseVisualStyleBackColor = true;
            this.btnResetEQ.Click += new System.EventHandler(this.btnResetEQ_Click);
            // 
            // chkboxAutoEQ
            // 
            this.chkboxAutoEQ.AutoSize = true;
            this.chkboxAutoEQ.Checked = true;
            this.chkboxAutoEQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxAutoEQ.Location = new System.Drawing.Point(199, 270);
            this.chkboxAutoEQ.Name = "chkboxAutoEQ";
            this.chkboxAutoEQ.Size = new System.Drawing.Size(144, 17);
            this.chkboxAutoEQ.TabIndex = 13;
            this.chkboxAutoEQ.Text = "Auto-EQ on loading song";
            this.chkboxAutoEQ.UseVisualStyleBackColor = true;
            this.chkboxAutoEQ.CheckedChanged += new System.EventHandler(this.chkboxAutoEQ_CheckedChanged);
            // 
            // chkboxEQOn
            // 
            this.chkboxEQOn.AutoSize = true;
            this.chkboxEQOn.Checked = true;
            this.chkboxEQOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxEQOn.Location = new System.Drawing.Point(199, 293);
            this.chkboxEQOn.Name = "chkboxEQOn";
            this.chkboxEQOn.Size = new System.Drawing.Size(107, 17);
            this.chkboxEQOn.TabIndex = 13;
            this.chkboxEQOn.Text = "Enable EQualizer";
            this.chkboxEQOn.UseVisualStyleBackColor = true;
            this.chkboxEQOn.CheckedChanged += new System.EventHandler(this.chkboxEQOn_CheckedChanged);
            // 
            // chkboxNormal
            // 
            this.chkboxNormal.AutoSize = true;
            this.chkboxNormal.Location = new System.Drawing.Point(199, 316);
            this.chkboxNormal.Name = "chkboxNormal";
            this.chkboxNormal.Size = new System.Drawing.Size(104, 17);
            this.chkboxNormal.TabIndex = 13;
            this.chkboxNormal.Text = "Normalize sound";
            this.chkboxNormal.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 352);
            this.Controls.Add(this.chkboxNormal);
            this.Controls.Add(this.chkboxEQOn);
            this.Controls.Add(this.chkboxAutoEQ);
            this.Controls.Add(this.btnResetEQ);
            this.Controls.Add(this.btnSaveEQSettings);
            this.Controls.Add(this.btnLoadEDJ);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.lblSampleRate);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblWinampPresets);
            this.Controls.Add(this.cboxWinampPresets);
            this.Controls.Add(this.lblMenos);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.lbl16k);
            this.Controls.Add(this.lbl14k);
            this.Controls.Add(this.lbl12k);
            this.Controls.Add(this.lbl6k);
            this.Controls.Add(this.lbl3k);
            this.Controls.Add(this.lbl1k);
            this.Controls.Add(this.lbl600);
            this.Controls.Add(this.lbl310);
            this.Controls.Add(this.lbl170);
            this.Controls.Add(this.lbl80);
            this.Controls.Add(this.tbar16k);
            this.Controls.Add(this.tbar14k);
            this.Controls.Add(this.tbar12k);
            this.Controls.Add(this.tbar6k);
            this.Controls.Add(this.tbar3k);
            this.Controls.Add(this.tbar1k);
            this.Controls.Add(this.tbar600);
            this.Controls.Add(this.tbar310);
            this.Controls.Add(this.tbar170);
            this.Controls.Add(this.tbar80);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tbarVolumen);
            this.Controls.Add(this.lblMeterRight);
            this.Controls.Add(this.lblMeterLeft);
            this.Controls.Add(this.audioDjStudio1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecualizador";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar170)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar310)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar600)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar1k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar3k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar6k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar12k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar14k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar16k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AudioDjStudio.AudioDjStudio audioDjStudio1;
        private System.Windows.Forms.Label lblMeterLeft;
        private System.Windows.Forms.Label lblMeterRight;
        private System.Windows.Forms.TrackBar tbarVolumen;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar tbar80;
        private System.Windows.Forms.Label lbl80;
        private System.Windows.Forms.TrackBar tbar170;
        private System.Windows.Forms.Label lbl170;
        private System.Windows.Forms.TrackBar tbar310;
        private System.Windows.Forms.Label lbl310;
        private System.Windows.Forms.TrackBar tbar600;
        private System.Windows.Forms.Label lbl600;
        private System.Windows.Forms.TrackBar tbar1k;
        private System.Windows.Forms.Label lbl1k;
        private System.Windows.Forms.TrackBar tbar3k;
        private System.Windows.Forms.Label lbl3k;
        private System.Windows.Forms.TrackBar tbar6k;
        private System.Windows.Forms.Label lbl6k;
        private System.Windows.Forms.TrackBar tbar12k;
        private System.Windows.Forms.Label lbl12k;
        private System.Windows.Forms.TrackBar tbar14k;
        private System.Windows.Forms.Label lbl14k;
        private System.Windows.Forms.TrackBar tbar16k;
        private System.Windows.Forms.Label lbl16k;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.Label lblMenos;
        private System.Windows.Forms.ComboBox cboxWinampPresets;
        private System.Windows.Forms.Label lblWinampPresets;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Button btnLoadEDJ;
        private System.Windows.Forms.Button btnSaveEQSettings;
        private System.Windows.Forms.Button btnResetEQ;
        private System.Windows.Forms.CheckBox chkboxAutoEQ;
        private System.Windows.Forms.CheckBox chkboxEQOn;
        private System.Windows.Forms.CheckBox chkboxNormal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

