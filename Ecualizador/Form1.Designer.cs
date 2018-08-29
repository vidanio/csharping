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
            this.components = new System.ComponentModel.Container();
            this.audioDjStudio1 = new AudioDjStudio.AudioDjStudio();
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
            this.progPlayback = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSpectrum = new System.Windows.Forms.Label();
            this.lblOscilloscope = new System.Windows.Forms.Label();
            this.lblVumeter = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWaveform = new System.Windows.Forms.Label();
            this.lbltxtOscilloscope = new System.Windows.Forms.Label();
            this.lbltxtSpectrum = new System.Windows.Forms.Label();
            this.lbltxtWaveform = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.PictureSpectrum = new System.Windows.Forms.PictureBox();
            this.numThresold = new System.Windows.Forms.NumericUpDown();
            this.numRelease = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numRatio = new System.Windows.Forms.NumericUpDown();
            this.grpCompress = new System.Windows.Forms.GroupBox();
            this.btnLoadValues = new System.Windows.Forms.Button();
            this.btnResetVal = new System.Windows.Forms.Button();
            this.lbltxtRatio = new System.Windows.Forms.Label();
            this.lbltxtRelease = new System.Windows.Forms.Label();
            this.lbltxtAttack = new System.Windows.Forms.Label();
            this.lbltxtThresold = new System.Windows.Forms.Label();
            this.lbltxtGain = new System.Windows.Forms.Label();
            this.numGain = new System.Windows.Forms.NumericUpDown();
            this.chkCompressor = new System.Windows.Forms.CheckBox();
            this.chkDCOffset = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatio)).BeginInit();
            this.grpCompress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
            this.SuspendLayout();
            // 
            // audioDjStudio1
            // 
            this.audioDjStudio1.FaderSettings = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.audioDjStudio1.LastError = AudioDjStudio.enumErrorCodes.ERR_NOERROR;
            this.audioDjStudio1.Location = new System.Drawing.Point(611, 15);
            this.audioDjStudio1.Name = "audioDjStudio1";
            this.audioDjStudio1.Size = new System.Drawing.Size(48, 48);
            this.audioDjStudio1.TabIndex = 0;
            this.audioDjStudio1.SoundDone += new AudioDjStudio.AudioDjStudio.PlayerEventHandler(this.audioDjStudio1_SoundDone);
            this.audioDjStudio1.EqualizerLoaded += new AudioDjStudio.AudioDjStudio.PlayerEventHandler(this.audioDjStudio1_EqualizerLoaded);
            // 
            // tbarVolumen
            // 
            this.tbarVolumen.Location = new System.Drawing.Point(16, 181);
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
            this.lblVolume.Location = new System.Drawing.Point(16, 165);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 13);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "Volumen";
            // 
            // tbar80
            // 
            this.tbar80.Location = new System.Drawing.Point(152, 181);
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
            this.lbl80.Location = new System.Drawing.Point(159, 165);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(38, 13);
            this.lbl80.TabIndex = 5;
            this.lbl80.Text = "80 Hz ";
            // 
            // tbar170
            // 
            this.tbar170.Location = new System.Drawing.Point(203, 181);
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
            this.lbl170.Location = new System.Drawing.Point(207, 165);
            this.lbl170.Name = "lbl170";
            this.lbl170.Size = new System.Drawing.Size(41, 13);
            this.lbl170.TabIndex = 5;
            this.lbl170.Text = "170 Hz";
            // 
            // tbar310
            // 
            this.tbar310.Location = new System.Drawing.Point(254, 181);
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
            this.lbl310.Location = new System.Drawing.Point(255, 165);
            this.lbl310.Name = "lbl310";
            this.lbl310.Size = new System.Drawing.Size(44, 13);
            this.lbl310.TabIndex = 5;
            this.lbl310.Text = "310 Hz ";
            // 
            // tbar600
            // 
            this.tbar600.Location = new System.Drawing.Point(305, 181);
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
            this.lbl600.Location = new System.Drawing.Point(309, 165);
            this.lbl600.Name = "lbl600";
            this.lbl600.Size = new System.Drawing.Size(41, 13);
            this.lbl600.TabIndex = 5;
            this.lbl600.Text = "600 Hz";
            // 
            // tbar1k
            // 
            this.tbar1k.Location = new System.Drawing.Point(356, 181);
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
            this.lbl1k.Location = new System.Drawing.Point(356, 165);
            this.lbl1k.Name = "lbl1k";
            this.lbl1k.Size = new System.Drawing.Size(35, 13);
            this.lbl1k.TabIndex = 5;
            this.lbl1k.Text = "1 kHz";
            // 
            // tbar3k
            // 
            this.tbar3k.Location = new System.Drawing.Point(407, 181);
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
            this.lbl3k.Location = new System.Drawing.Point(404, 165);
            this.lbl3k.Name = "lbl3k";
            this.lbl3k.Size = new System.Drawing.Size(35, 13);
            this.lbl3k.TabIndex = 5;
            this.lbl3k.Text = "3 kHz";
            // 
            // tbar6k
            // 
            this.tbar6k.Location = new System.Drawing.Point(458, 181);
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
            this.lbl6k.Location = new System.Drawing.Point(455, 165);
            this.lbl6k.Name = "lbl6k";
            this.lbl6k.Size = new System.Drawing.Size(35, 13);
            this.lbl6k.TabIndex = 5;
            this.lbl6k.Text = "6 kHz";
            // 
            // tbar12k
            // 
            this.tbar12k.Location = new System.Drawing.Point(509, 181);
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
            this.lbl12k.Location = new System.Drawing.Point(506, 165);
            this.lbl12k.Name = "lbl12k";
            this.lbl12k.Size = new System.Drawing.Size(41, 13);
            this.lbl12k.TabIndex = 5;
            this.lbl12k.Text = "12 kHz";
            // 
            // tbar14k
            // 
            this.tbar14k.Location = new System.Drawing.Point(560, 181);
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
            this.lbl14k.Location = new System.Drawing.Point(557, 165);
            this.lbl14k.Name = "lbl14k";
            this.lbl14k.Size = new System.Drawing.Size(41, 13);
            this.lbl14k.TabIndex = 5;
            this.lbl14k.Text = "14 kHz";
            // 
            // tbar16k
            // 
            this.tbar16k.Location = new System.Drawing.Point(611, 181);
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
            this.lbl16k.Location = new System.Drawing.Point(609, 165);
            this.lbl16k.Name = "lbl16k";
            this.lbl16k.Size = new System.Drawing.Size(41, 13);
            this.lbl16k.TabIndex = 5;
            this.lbl16k.Text = "16 kHz";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(133, 181);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 6;
            this.lblMas.Text = "+";
            // 
            // lblMenos
            // 
            this.lblMenos.AutoSize = true;
            this.lblMenos.Location = new System.Drawing.Point(133, 292);
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
            this.cboxWinampPresets.Location = new System.Drawing.Point(19, 366);
            this.cboxWinampPresets.Name = "cboxWinampPresets";
            this.cboxWinampPresets.Size = new System.Drawing.Size(160, 21);
            this.cboxWinampPresets.TabIndex = 7;
            this.cboxWinampPresets.SelectedIndexChanged += new System.EventHandler(this.cboxWinampPresets_SelectedIndexChanged);
            // 
            // lblWinampPresets
            // 
            this.lblWinampPresets.AutoSize = true;
            this.lblWinampPresets.Location = new System.Drawing.Point(44, 350);
            this.lblWinampPresets.Name = "lblWinampPresets";
            this.lblWinampPresets.Size = new System.Drawing.Size(112, 13);
            this.lblWinampPresets.TabIndex = 8;
            this.lblWinampPresets.Text = "Winamp (TM) Presets:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 117);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(104, 117);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(185, 117);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(266, 117);
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
            this.lblSampleRate.Location = new System.Drawing.Point(356, 122);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(71, 13);
            this.lblSampleRate.TabIndex = 10;
            this.lblSampleRate.Text = "Sample Rate:";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(19, 9);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(37, 13);
            this.lblSong.TabIndex = 11;
            this.lblSong.Text = "(none)";
            // 
            // btnLoadEDJ
            // 
            this.btnLoadEDJ.Location = new System.Drawing.Point(203, 321);
            this.btnLoadEDJ.Name = "btnLoadEDJ";
            this.btnLoadEDJ.Size = new System.Drawing.Size(131, 23);
            this.btnLoadEDJ.TabIndex = 12;
            this.btnLoadEDJ.Text = "Load EQ File";
            this.btnLoadEDJ.UseVisualStyleBackColor = true;
            this.btnLoadEDJ.Click += new System.EventHandler(this.btnLoadEDJ_Click);
            // 
            // btnSaveEQSettings
            // 
            this.btnSaveEQSettings.Location = new System.Drawing.Point(359, 321);
            this.btnSaveEQSettings.Name = "btnSaveEQSettings";
            this.btnSaveEQSettings.Size = new System.Drawing.Size(131, 23);
            this.btnSaveEQSettings.TabIndex = 12;
            this.btnSaveEQSettings.Text = "Save EQ Settings";
            this.btnSaveEQSettings.UseVisualStyleBackColor = true;
            this.btnSaveEQSettings.Click += new System.EventHandler(this.btnSaveEQSettings_Click);
            // 
            // btnResetEQ
            // 
            this.btnResetEQ.Location = new System.Drawing.Point(519, 321);
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
            this.chkboxAutoEQ.Location = new System.Drawing.Point(359, 370);
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
            this.chkboxEQOn.Location = new System.Drawing.Point(227, 370);
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
            this.chkboxNormal.Location = new System.Drawing.Point(525, 370);
            this.chkboxNormal.Name = "chkboxNormal";
            this.chkboxNormal.Size = new System.Drawing.Size(104, 17);
            this.chkboxNormal.TabIndex = 13;
            this.chkboxNormal.Text = "Normalize sound";
            this.chkboxNormal.UseVisualStyleBackColor = true;
            this.chkboxNormal.CheckedChanged += new System.EventHandler(this.chkboxNormal_CheckedChanged);
            // 
            // progPlayback
            // 
            this.progPlayback.ForeColor = System.Drawing.Color.Red;
            this.progPlayback.Location = new System.Drawing.Point(19, 93);
            this.progPlayback.Name = "progPlayback";
            this.progPlayback.Size = new System.Drawing.Size(632, 10);
            this.progPlayback.Step = 1;
            this.progPlayback.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(19, 74);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Text = "Duration:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(162, 74);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position:";
            // 
            // lblSpectrum
            // 
            this.lblSpectrum.BackColor = System.Drawing.Color.Black;
            this.lblSpectrum.Location = new System.Drawing.Point(238, 499);
            this.lblSpectrum.Name = "lblSpectrum";
            this.lblSpectrum.Size = new System.Drawing.Size(189, 69);
            this.lblSpectrum.TabIndex = 17;
            // 
            // lblOscilloscope
            // 
            this.lblOscilloscope.BackColor = System.Drawing.Color.Black;
            this.lblOscilloscope.Location = new System.Drawing.Point(16, 499);
            this.lblOscilloscope.Name = "lblOscilloscope";
            this.lblOscilloscope.Size = new System.Drawing.Size(189, 69);
            this.lblOscilloscope.TabIndex = 17;
            // 
            // lblVumeter
            // 
            this.lblVumeter.BackColor = System.Drawing.Color.Black;
            this.lblVumeter.Location = new System.Drawing.Point(85, 174);
            this.lblVumeter.Name = "lblVumeter";
            this.lblVumeter.Size = new System.Drawing.Size(24, 140);
            this.lblVumeter.TabIndex = 18;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(21, 33);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 19;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title:";
            // 
            // lblWaveform
            // 
            this.lblWaveform.BackColor = System.Drawing.Color.Black;
            this.lblWaveform.Location = new System.Drawing.Point(461, 499);
            this.lblWaveform.Name = "lblWaveform";
            this.lblWaveform.Size = new System.Drawing.Size(189, 69);
            this.lblWaveform.TabIndex = 17;
            // 
            // lbltxtOscilloscope
            // 
            this.lbltxtOscilloscope.AutoSize = true;
            this.lbltxtOscilloscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtOscilloscope.Location = new System.Drawing.Point(67, 486);
            this.lbltxtOscilloscope.Name = "lbltxtOscilloscope";
            this.lbltxtOscilloscope.Size = new System.Drawing.Size(79, 13);
            this.lbltxtOscilloscope.TabIndex = 21;
            this.lbltxtOscilloscope.Text = "Oscilloscope";
            // 
            // lbltxtSpectrum
            // 
            this.lbltxtSpectrum.AutoSize = true;
            this.lbltxtSpectrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtSpectrum.Location = new System.Drawing.Point(302, 486);
            this.lbltxtSpectrum.Name = "lbltxtSpectrum";
            this.lbltxtSpectrum.Size = new System.Drawing.Size(60, 13);
            this.lbltxtSpectrum.TabIndex = 21;
            this.lbltxtSpectrum.Text = "Spectrum";
            // 
            // lbltxtWaveform
            // 
            this.lbltxtWaveform.AutoSize = true;
            this.lbltxtWaveform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtWaveform.Location = new System.Drawing.Point(527, 486);
            this.lbltxtWaveform.Name = "lbltxtWaveform";
            this.lbltxtWaveform.Size = new System.Drawing.Size(64, 13);
            this.lbltxtWaveform.TabIndex = 21;
            this.lbltxtWaveform.Text = "Waveform";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(356, 74);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(24, 13);
            this.lblPercent.TabIndex = 22;
            this.lblPercent.Text = "0 %";
            // 
            // PictureSpectrum
            // 
            this.PictureSpectrum.BackColor = System.Drawing.Color.Black;
            this.PictureSpectrum.Location = new System.Drawing.Point(16, 585);
            this.PictureSpectrum.Name = "PictureSpectrum";
            this.PictureSpectrum.Size = new System.Drawing.Size(634, 164);
            this.PictureSpectrum.TabIndex = 23;
            this.PictureSpectrum.TabStop = false;
            // 
            // numThresold
            // 
            this.numThresold.Location = new System.Drawing.Point(226, 18);
            this.numThresold.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numThresold.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numThresold.Name = "numThresold";
            this.numThresold.Size = new System.Drawing.Size(57, 20);
            this.numThresold.TabIndex = 24;
            this.numThresold.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            // 
            // numRelease
            // 
            this.numRelease.Location = new System.Drawing.Point(387, 51);
            this.numRelease.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRelease.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRelease.Name = "numRelease";
            this.numRelease.Size = new System.Drawing.Size(76, 20);
            this.numRelease.TabIndex = 24;
            this.numRelease.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(387, 18);
            this.numAttack.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAttack.Name = "numAttack";
            this.numAttack.Size = new System.Drawing.Size(76, 20);
            this.numAttack.TabIndex = 24;
            this.numAttack.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numRatio
            // 
            this.numRatio.Location = new System.Drawing.Point(225, 51);
            this.numRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatio.Name = "numRatio";
            this.numRatio.Size = new System.Drawing.Size(58, 20);
            this.numRatio.TabIndex = 24;
            this.numRatio.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // grpCompress
            // 
            this.grpCompress.Controls.Add(this.btnLoadValues);
            this.grpCompress.Controls.Add(this.btnResetVal);
            this.grpCompress.Controls.Add(this.lbltxtRatio);
            this.grpCompress.Controls.Add(this.lbltxtRelease);
            this.grpCompress.Controls.Add(this.lbltxtAttack);
            this.grpCompress.Controls.Add(this.lbltxtThresold);
            this.grpCompress.Controls.Add(this.lbltxtGain);
            this.grpCompress.Controls.Add(this.numAttack);
            this.grpCompress.Controls.Add(this.numRatio);
            this.grpCompress.Controls.Add(this.numThresold);
            this.grpCompress.Controls.Add(this.numGain);
            this.grpCompress.Controls.Add(this.numRelease);
            this.grpCompress.Controls.Add(this.chkCompressor);
            this.grpCompress.Location = new System.Drawing.Point(16, 393);
            this.grpCompress.Name = "grpCompress";
            this.grpCompress.Size = new System.Drawing.Size(635, 90);
            this.grpCompress.TabIndex = 25;
            this.grpCompress.TabStop = false;
            this.grpCompress.Text = "Compressor";
            // 
            // btnLoadValues
            // 
            this.btnLoadValues.BackColor = System.Drawing.Color.Blue;
            this.btnLoadValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadValues.ForeColor = System.Drawing.Color.White;
            this.btnLoadValues.Location = new System.Drawing.Point(503, 45);
            this.btnLoadValues.Name = "btnLoadValues";
            this.btnLoadValues.Size = new System.Drawing.Size(110, 29);
            this.btnLoadValues.TabIndex = 27;
            this.btnLoadValues.Text = "Load Values";
            this.btnLoadValues.UseVisualStyleBackColor = false;
            this.btnLoadValues.Click += new System.EventHandler(this.btnLoadValues_Click);
            // 
            // btnResetVal
            // 
            this.btnResetVal.BackColor = System.Drawing.Color.Blue;
            this.btnResetVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetVal.ForeColor = System.Drawing.Color.White;
            this.btnResetVal.Location = new System.Drawing.Point(503, 12);
            this.btnResetVal.Name = "btnResetVal";
            this.btnResetVal.Size = new System.Drawing.Size(110, 29);
            this.btnResetVal.TabIndex = 27;
            this.btnResetVal.Text = "Reset Values";
            this.btnResetVal.UseVisualStyleBackColor = false;
            this.btnResetVal.Click += new System.EventHandler(this.btnResetVal_Click);
            // 
            // lbltxtRatio
            // 
            this.lbltxtRatio.AutoSize = true;
            this.lbltxtRatio.Location = new System.Drawing.Point(147, 52);
            this.lbltxtRatio.Name = "lbltxtRatio";
            this.lbltxtRatio.Size = new System.Drawing.Size(35, 13);
            this.lbltxtRatio.TabIndex = 26;
            this.lbltxtRatio.Text = "Ratio:";
            // 
            // lbltxtRelease
            // 
            this.lbltxtRelease.AutoSize = true;
            this.lbltxtRelease.Location = new System.Drawing.Point(310, 53);
            this.lbltxtRelease.Name = "lbltxtRelease";
            this.lbltxtRelease.Size = new System.Drawing.Size(71, 13);
            this.lbltxtRelease.TabIndex = 26;
            this.lbltxtRelease.Text = "Release (ms):";
            // 
            // lbltxtAttack
            // 
            this.lbltxtAttack.AutoSize = true;
            this.lbltxtAttack.Location = new System.Drawing.Point(310, 23);
            this.lbltxtAttack.Name = "lbltxtAttack";
            this.lbltxtAttack.Size = new System.Drawing.Size(63, 13);
            this.lbltxtAttack.TabIndex = 26;
            this.lbltxtAttack.Text = "Attack (ms):";
            // 
            // lbltxtThresold
            // 
            this.lbltxtThresold.AutoSize = true;
            this.lbltxtThresold.Location = new System.Drawing.Point(147, 20);
            this.lbltxtThresold.Name = "lbltxtThresold";
            this.lbltxtThresold.Size = new System.Drawing.Size(73, 13);
            this.lbltxtThresold.TabIndex = 26;
            this.lbltxtThresold.Text = "Thresold (dB):";
            // 
            // lbltxtGain
            // 
            this.lbltxtGain.AutoSize = true;
            this.lbltxtGain.Location = new System.Drawing.Point(6, 52);
            this.lbltxtGain.Name = "lbltxtGain";
            this.lbltxtGain.Size = new System.Drawing.Size(54, 13);
            this.lbltxtGain.TabIndex = 25;
            this.lbltxtGain.Text = "Gain (dB):";
            // 
            // numGain
            // 
            this.numGain.Location = new System.Drawing.Point(66, 50);
            this.numGain.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numGain.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numGain.Name = "numGain";
            this.numGain.Size = new System.Drawing.Size(57, 20);
            this.numGain.TabIndex = 24;
            // 
            // chkCompressor
            // 
            this.chkCompressor.AutoSize = true;
            this.chkCompressor.Location = new System.Drawing.Point(8, 19);
            this.chkCompressor.Name = "chkCompressor";
            this.chkCompressor.Size = new System.Drawing.Size(117, 17);
            this.chkCompressor.TabIndex = 13;
            this.chkCompressor.Text = "Enable Compressor";
            this.chkCompressor.UseVisualStyleBackColor = true;
            this.chkCompressor.CheckedChanged += new System.EventHandler(this.chkCompressor_CheckedChanged);
            // 
            // chkDCOffset
            // 
            this.chkDCOffset.AutoSize = true;
            this.chkDCOffset.Location = new System.Drawing.Point(534, 121);
            this.chkDCOffset.Name = "chkDCOffset";
            this.chkDCOffset.Size = new System.Drawing.Size(117, 17);
            this.chkDCOffset.TabIndex = 26;
            this.chkDCOffset.Text = "DC Offset Removal";
            this.chkDCOffset.UseVisualStyleBackColor = true;
            this.chkDCOffset.CheckedChanged += new System.EventHandler(this.chkDCOffset_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(674, 761);
            this.Controls.Add(this.chkDCOffset);
            this.Controls.Add(this.grpCompress);
            this.Controls.Add(this.PictureSpectrum);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lbltxtWaveform);
            this.Controls.Add(this.lbltxtSpectrum);
            this.Controls.Add(this.lbltxtOscilloscope);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblVumeter);
            this.Controls.Add(this.lblOscilloscope);
            this.Controls.Add(this.lblWaveform);
            this.Controls.Add(this.lblSpectrum);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.progPlayback);
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
            this.Controls.Add(this.audioDjStudio1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 800);
            this.MinimumSize = new System.Drawing.Size(690, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecualizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatio)).EndInit();
            this.grpCompress.ResumeLayout(false);
            this.grpCompress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AudioDjStudio.AudioDjStudio audioDjStudio1;
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
        private System.Windows.Forms.ProgressBar progPlayback;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSpectrum;
        private System.Windows.Forms.Label lblOscilloscope;
        private System.Windows.Forms.Label lblVumeter;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWaveform;
        private System.Windows.Forms.Label lbltxtOscilloscope;
        private System.Windows.Forms.Label lbltxtSpectrum;
        private System.Windows.Forms.Label lbltxtWaveform;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.PictureBox PictureSpectrum;
        private System.Windows.Forms.NumericUpDown numThresold;
        private System.Windows.Forms.NumericUpDown numRelease;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numRatio;
        private System.Windows.Forms.GroupBox grpCompress;
        private System.Windows.Forms.Label lbltxtRatio;
        private System.Windows.Forms.Label lbltxtThresold;
        private System.Windows.Forms.Label lbltxtGain;
        private System.Windows.Forms.NumericUpDown numGain;
        private System.Windows.Forms.CheckBox chkCompressor;
        private System.Windows.Forms.Label lbltxtAttack;
        private System.Windows.Forms.Label lbltxtRelease;
        private System.Windows.Forms.Button btnLoadValues;
        private System.Windows.Forms.Button btnResetVal;
        private System.Windows.Forms.CheckBox chkDCOffset;
    }
}

