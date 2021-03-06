﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AudioDjStudio;

namespace Ecualizador
{
    public partial class MainForm : Form
    {
        private string m_strLoadedSongPathname = "";
        private double songduration = 0;
        private byte[] KeyCode = new byte[] { 11, 22, 33, 44, 55, 66, 77, 88 }; // Isaac decription keys

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Verifica la presencia de tarjetas de audio
            Int32 nOutputs = audioDjStudio1.GetOutputDevicesCount();
            if (nOutputs == 0)
            {
                MessageBox.Show("No hay dispositivos de audio.", "Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            // Iniciamos el sistema de audio
            audioDjStudio1.InitSoundSystem(1, 0, 0, 0, 0, -1);

            // vumeter integrado
            audioDjStudio1.DisplayVUMeter.Create(0, lblVumeter.Handle);
            audioDjStudio1.DisplayVUMeter.Show(0, true);

            // spectrum integrado
            audioDjStudio1.DisplaySpectrum.Create(0, lblSpectrum.Handle);
            audioDjStudio1.DisplaySpectrum.Show(0, true);

            // osciloscopio integrado
            audioDjStudio1.DisplayOscilloscope.Create(0, lblOscilloscope.Handle);
            audioDjStudio1.DisplayOscilloscope.set_ColorLine(0, Color.Red);
            audioDjStudio1.DisplayOscilloscope.Show(0, true);

            // waveform
            audioDjStudio1.DisplayWaveform.Create(0, lblWaveform.Handle);
            audioDjStudio1.DisplayWaveform.set_ColorLine(0, Color.Red);
            audioDjStudio1.DisplayWaveform.Show(0, true);

            // FFT enhanced spectrum
            audioDjStudio1.DisplaySpectrumEnh.Create(0, PictureSpectrum.Handle);
            audioDjStudio1.DisplaySpectrumEnh.Show(0, true);
            SPECTR_ENH_GENERAL_SETTINGS descSpectrumEnhGeneral = new SPECTR_ENH_GENERAL_SETTINGS();
            audioDjStudio1.DisplaySpectrumEnh.SettingsGeneralGet(0, ref descSpectrumEnhGeneral);
            descSpectrumEnhGeneral.nGraphType = enumSpectrumEnhTypes.SPECTR_ENH_AREA_LEFT_TOP;
            descSpectrumEnhGeneral.bBackBitmapVisible = false;
            descSpectrumEnhGeneral.nResolution = 8192;
            audioDjStudio1.DisplaySpectrumEnh.SettingsGeneralSet(0, descSpectrumEnhGeneral);

            cboxWinampPresets.SelectedIndex = 0;
            audioDjStudio1.EnableAutoEqualiz = true;
            audioDjStudio1.CustomDSP.UseFloatSamples(true); // necesario para normalizar

            CreateEqualizerBands(false);
        }

        private void CreateEqualizerBands(bool bHasFile)
        {
            tbar6k.Visible = true; lbl6k.Visible = true;
            tbar12k.Visible = true; lbl12k.Visible = true;
            tbar14k.Visible = true; lbl14k.Visible = true;
            tbar16k.Visible = true; lbl16k.Visible = true;

            // ocultar los sliders que no son utiles a ciertas frecuencias de sampleo
            if (bHasFile)
            {
                UInt32 nSampleRate;
                SoundInfo info = new SoundInfo();
                audioDjStudio1.ReadSoundInfo(0, ref info);
                nSampleRate = info.nFrequency;
                lblSampleRate.Text = "Sample rate: " + nSampleRate.ToString() + " Hz";
                if (nSampleRate <= 11025)
                {
                    tbar6k.Visible = false; lbl6k.Visible = false;
                    tbar12k.Visible = false; lbl12k.Visible = false;
                    tbar14k.Visible = false; lbl14k.Visible = false;
                    tbar16k.Visible = false; lbl16k.Visible = false;
                }
                else if (nSampleRate <= 22050)
                {
                    tbar12k.Visible = false; lbl12k.Visible = false;
                    tbar14k.Visible = false; lbl14k.Visible = false;
                    tbar16k.Visible = false; lbl16k.Visible = false;
                }
                else if (nSampleRate <= 44100)
                    tbar16k.Visible = false; lbl16k.Visible = false;
            }
            else
            {
                //se crean las bandas de ecualizador como efecto del control audio la primera vez
                audioDjStudio1.Effects.EqualizerBandAdd(0, 80, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 170, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 310, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 600, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 1000, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 3000, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 6000, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 12000, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 14000, 12, 0);
                audioDjStudio1.Effects.EqualizerBandAdd(0, 16000, 12, 0);
            }

            UpdateEqualizerSliders(); // actualiza la posición de los sliders
        }

        private void UpdateEqualizerSliders()
        {
            float fFrequency = 0.0f;
            float fBandwidth = 0.0f;
            float fGain = 0.0f;

            // recoge el numero de bandas del ecualizador
            Int32 nBands = 0;
            audioDjStudio1.Effects.EqualizerBandCountGet(0, ref nBands);
            for (Int32 i = 0; i < nBands; i++)
            {
                // recoge la frecuencia de cada banda del ecualizador
                audioDjStudio1.Effects.EqualizerBandFrequencyGet(0, i, ref fFrequency);

                // recoge los valores de cada banda del ecualizador
                audioDjStudio1.Effects.EqualizerBandParamsGet(0, fFrequency, ref fBandwidth, ref fGain);

                // actualiza los sliders de cada banda
                switch (i)
                {
                    case 0: tbar80.Value = (Int16)fGain * 100; break;
                    case 1: tbar170.Value = (Int16)fGain * 100; break;
                    case 2: tbar310.Value = (Int16)fGain * 100; break;
                    case 3: tbar600.Value = (Int16)fGain * 100; break;
                    case 4: tbar1k.Value = (Int16)fGain * 100; break;
                    case 5: tbar3k.Value = (Int16)fGain * 100; break;
                    case 6: tbar6k.Value = (Int16)fGain * 100; break;
                    case 7: tbar12k.Value = (Int16)fGain * 100; break;
                    case 8: tbar14k.Value = (Int16)fGain * 100; break;
                    case 9: tbar16k.Value = (Int16)fGain * 100; break;
                }
            }
        }

        // evento de carga de ecualizador
        private void audioDjStudio1_EqualizerLoaded(object sender, PlayerEventArgs e)
        {
            // actualiza sliders
            UpdateEqualizerSliders();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Supported Sounds (*.mp3;*.mp2;*.wav;*.ogg;*.aiff;*.wma;*.wmv;*.asx;*.asf;" +
                "*.m4a;*.mp4;*.flac;*.aac;*.ac3;*.wv;" +
                "*.au;*.aif;*.w64;*.voc;*.sf;*.paf;*.pvf;*.caf;*.svx ;" +
                "*.it;*.xm;*.s3m;*.mod;*.mtm;*.mo3;*.cda;*.xxx)|" +
                "*.mp3;*.mp2;*.wav;*.ogg;*.aiff;*.wma;*.wmv;*.asx;*.asf;" +
                "*.m4a;*.mp4;*.flac;*.aac;*.ac3;*.wv;" +
                "*.au;*.aif;*.w64;*.voc;*.sf;*.paf;*.pvf;*.caf;*.svx ;" +
                "*.it;*.xm;*.s3m;*.mod;*.mtm;*.mo3;*.cda;*.xxx|" +
                "MP3 and MP2 sounds (*.mp3;*.mp2)|*.mp3;*.mp2|" +
                "AAC and MP4 sounds (*.aac;*.mp4)|*.aac;*.mp4|" +
                "WAV sounds (*.wav)|*.wav|" +
                "OGG Vorbis sounds (*.ogg)|*.ogg|" +
                "AIFF sounds (*.aiff)|*.aiff|" +
                "Windows Media sounds (*.wma;*.wmv;*.asx;*.asf)|*.wma;*.wmv;*.asx;*.asf|" +
                "AC3 sounds (*.ac3)|*.ac3;|" +
                "ALAC sounds (*.m4a)|*.ac3;|" +
                "FLAC sounds (*.flac)|*.flac;|" +
                "WavPack sounds (*.wv)|*.wv;|" +
                "MOD music (*.it;*.xm;*.s3m;*.mod;*.mtm;*.mo3)|*.it;*.xm;*.s3m;*.mod;*.mtm;*.mo3|" +
                "CD tracks (*.cda)|*.cda";

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // vemos si el fichero esta cifrado *.xxx
                bool cifrado = false;
                byte[] bytes = null;

                try
                {
                    if (Path.GetExtension(openFileDialog1.FileName) == ".xxx") cifrado = true;
                    bytes = File.ReadAllBytes(openFileDialog1.FileName);
                    // autoEQ manual ya que solo funciona automatico con LoadSound()
                    if (audioDjStudio1.EnableAutoEqualiz)
                    {
                        if (File.Exists(openFileDialog1.FileName + ".edj"))
                        {
                            audioDjStudio1.Effects.EqualizerLoadFromFile(0, openFileDialog1.FileName + ".edj");
                        }
                        else
                        {
                            if (cboxWinampPresets.SelectedIndex == 0)
                                btnResetEQ_Click(sender, e);
                            else
                                audioDjStudio1.Effects.EqualizerLoadPresets(0, (enumEqualizerPresets)cboxWinampPresets.SelectedIndex - 1);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No puedo leer el fichero " + openFileDialog1.FileName, "Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // stop and close any loaded sound
                audioDjStudio1.StopSound(0);
                audioDjStudio1.CloseSound(0);
                resetInfo();
                lblSong.Text = "";

                // descifrado en RAM, si cifrado = true
                if (cifrado) for (int i= 0; i < bytes.Length; i++) bytes[i] ^= KeyCode[i % 8];

                if (audioDjStudio1.LoadSoundFromMemory(0, bytes, bytes.Length) == enumErrorCodes.NOERROR) // carga en fichero en el player 0
                {
                    m_strLoadedSongPathname = openFileDialog1.FileName;
                    lblSong.Text = Path.GetFileName(m_strLoadedSongPathname);

                    SoundInfo2 info = new SoundInfo2();
                    audioDjStudio1.SoundInfoGet(0, ref info);
                    lblArtist.Text = "Artist: " + info.strMP3Tag1Artist;
                    lblTitle.Text = "Title: " + info.strMP3Tag1Title;

                    // resetea las bandas del ecualizador
                    CreateEqualizerBands(true);
                    // recoge la duración de la canción cargada
                    audioDjStudio1.SoundDurationGet(0, ref songduration, false); // millisecs
                    lblDuration.Text = "Duration: " + convertMillisecsToString(songduration);
                }
                else
                {
                    MessageBox.Show("No puedo cargar el fichero " + openFileDialog1.FileName, "Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string convertMillisecsToString(double millisecs)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(millisecs);

            return string.Format("{0:D2}:{1:D2}.{2:D3}", t.Minutes, t.Seconds, t.Milliseconds);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            enumPlayerStatus nStatus = audioDjStudio1.GetPlayerStatus(0); // recogemos el estado del player 0
            if ((nStatus != enumPlayerStatus.SOUND_PAUSED) && (nStatus != enumPlayerStatus.SOUND_NONE)) // evitamos dejar el boton pause/resume sin sentido
            {
                audioDjStudio1.PlaySound(0); // reproduce lo que hay cargado en el Player 0
                timer1.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            enumPlayerStatus nStatus = audioDjStudio1.GetPlayerStatus(0); // recogemos el estado del player 0
            if (nStatus != enumPlayerStatus.SOUND_NONE)
            {
                if (nStatus == enumPlayerStatus.SOUND_PAUSED)
                {
                    audioDjStudio1.ResumeSound(0); // resume
                    btnPause.Text = "Pause";
                    timer1.Start();
                }
                else
                {
                    audioDjStudio1.PauseSound(0); // pause
                    btnPause.Text = "Resume";
                    timer1.Stop();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            enumPlayerStatus nStatus = audioDjStudio1.GetPlayerStatus(0); // recogemos el estado del player 0
            if (nStatus == enumPlayerStatus.SOUND_PAUSED) // evitamos dejar el boton pause/resume sin sentido
            {
                btnPause.Text = "Pause";
            }
            audioDjStudio1.StopSound(0); // parar el player 0
            timer1.Stop();
            resetInfo();
        }

        private void tbarVolumen_Scroll(object sender, EventArgs e)
        {
            // ajustamos volumen del player 0
            audioDjStudio1.StreamVolumeLevelSet(0, (float)tbarVolumen.Value, enumVolumeScales.SCALE_LINEAR);
        }

        private void btnLoadEDJ_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Equalizer files (*.edj)|*.edj";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (audioDjStudio1.Effects.EqualizerLoadFromFile(0, openFileDialog1.FileName) != enumErrorCodes.NOERROR)
                    MessageBox.Show("No puedo cargar el fichero ecualizador " + openFileDialog1.FileName, "Error importante");
                else
                    // cargar el fichero hará activar el EQ
                    chkboxEQOn.Checked = true;
            }
        }

        private void btnSaveEQSettings_Click(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerSaveToFile(0, m_strLoadedSongPathname + ".edj");
        }

        private void btnResetEQ_Click(object sender, EventArgs e)
        {
            cboxWinampPresets.SelectedIndex = 0;
            audioDjStudio1.Effects.EqualizerReset(0);

            UpdateEqualizerSliders();
        }

        private void cboxWinampPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxWinampPresets.SelectedIndex == 0)
            {
                // resetear EQ y salir
                btnResetEQ_Click(sender, e);
                return;
            }

            // cargar EQ con un preset
            audioDjStudio1.Effects.EqualizerLoadPresets(0, (enumEqualizerPresets)cboxWinampPresets.SelectedIndex - 1);

            // activar el EQ
            chkboxEQOn.Checked = true;
        }

        private void tbar80_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 80, ((float)tbar80.Value / 100.0f));
        }

        private void tbar170_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 170, ((float)tbar170.Value / 100.0f));
        }

        private void tbar310_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 310, ((float)tbar310.Value / 100.0f));
        }

        private void tbar600_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 600, ((float)tbar600.Value / 100.0f));
        }

        private void tbar1k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 1000, ((float)tbar1k.Value / 100.0f));
        }

        private void tbar3k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 3000, ((float)tbar3k.Value / 100.0f));
        }

        private void tbar6k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 6000, ((float)tbar6k.Value / 100.0f));
        }

        private void tbar12k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 12000, ((float)tbar12k.Value / 100.0f));
        }

        private void tbar14k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 14000, ((float)tbar14k.Value / 100.0f));
        }

        private void tbar16k_Scroll(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerBandGainSet(0, 16000, ((float)tbar16k.Value / 100.0f));
        }

        private void chkboxEQOn_CheckedChanged(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.EqualizerEnable(0, chkboxEQOn.Checked);
        }

        private void chkboxAutoEQ_CheckedChanged(object sender, EventArgs e)
        {
            audioDjStudio1.EnableAutoEqualiz = chkboxAutoEQ.Checked;
        }

        private void chkboxNormal_CheckedChanged(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.NormalizationEnable(0, chkboxNormal.Checked, 100, 100, 100);
        }

        // evento cuando se acaba una canción
        private void audioDjStudio1_SoundDone(object sender, PlayerEventArgs e)
        {
            resetInfo();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double position = 0;
            audioDjStudio1.SoundPositionGet(0, ref position, false);
            lblPosition.Text = "Position: " + convertMillisecsToString(position);

            double percentage = 0;
            percentage = position / songduration * 100.00;
            progPlayback.Value = (int)percentage;
            lblPercent.Text = string.Format("{0} %", (int)percentage);
        }

        private void resetInfo()
        {
            progPlayback.Value = 0;
            lblPosition.Text = "Position: ";
            lblPercent.Text = "0 %";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }

        private void btnResetVal_Click(object sender, EventArgs e)
        {
            numGain.Value = 0;
            numThresold.Value = -15;
            numRatio.Value = 3;
            numAttack.Value = 10;
            numRelease.Value = 200;
        }

        private void btnLoadValues_Click(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.CompressorReset(0);
            audioDjStudio1.Effects.CompressorApply(0, enumChannelMasks.CHANNEL_MASK_ALL, (float)numGain.Value, (float)numThresold.Value, (float)numRatio.Value, (float)numAttack.Value, (float)numRelease.Value, 1);
        }

        private void chkCompressor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompressor.Checked)
            {
                audioDjStudio1.Effects.CompressorApply(0, enumChannelMasks.CHANNEL_MASK_ALL, (float)numGain.Value, (float)numThresold.Value, (float)numRatio.Value, (float)numAttack.Value, (float)numRelease.Value, 1);
            }
            else
            {
                audioDjStudio1.Effects.CompressorReset(0);
            }
        }

        private void chkDCOffset_CheckedChanged(object sender, EventArgs e)
        {
            audioDjStudio1.Effects.DcOffsetRemovalEnable(0, chkDCOffset.Checked);
        }
    }
}
