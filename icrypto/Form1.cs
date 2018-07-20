using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace icrypto
{
    public partial class Form1 : Form
    {
        private const byte KEYCODE = 0x45;
        private IEnumerable<string> ficheros;
        
        public Form1()
        {
            InitializeComponent();
        }

        //Carga principal
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxRutas.Visible = false;
            lblInfoCrypt.Visible = false;
        }
        //Ruta de Entrada
        private void txtEntradaEnc_Click(object sender, EventArgs e)
        {
            if (DirectorioEntrada.ShowDialog() == DialogResult.OK)
            {
                emptySelects.Clear();
                ficherosParaEncriptar.Items.Clear();
                ficherosEncriptados.Items.Clear();
                txtEntradaEnc.Text = DirectorioEntrada.SelectedPath;
                lblInfoCrypt.Visible = false;
                if (radioEncript.Checked)
                {
                    string[] normal_exts = { ".mp3", ".wma" };
                    //Obtenemos los ficheros; de ese directorio y sus sub-directorios
                    ficheros = Directory.EnumerateFiles(DirectorioEntrada.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => normal_exts.Any(ext => ext == Path.GetExtension(s)));
                    if (ficheros.Count() == 0)
                    {
                        emptySelects.SetError(txtEntradaEnc, "No hay ficheros para cifrar");
                    }
                    else
                    {
                        foreach (string file in ficheros)
                        {
                            ficherosParaEncriptar.Items.Add(file);
                        }
                    }
                }
                if (radioDecript.Checked)
                {
                    string[] encrypt_exts = { ".xxx" };
                    //Obtenemos los ficheros; de ese directorio y sus sub-directorios
                    ficheros = Directory.EnumerateFiles(DirectorioEntrada.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => encrypt_exts.Any(ext => ext == Path.GetExtension(s)));
                    if (ficheros.Count() == 0)
                    {
                        emptySelects.SetError(txtEntradaEnc, "No hay ficheros para descifrar");
                    }
                    else
                    {
                        foreach (string file in ficheros)
                        {
                            ficherosParaEncriptar.Items.Add(file);
                        }
                    }
                }
            }
        }
        //Ruta de Salida
        private void txtSalidaEnc_Click(object sender, EventArgs e)
        {
            if (DirectorioSalida.ShowDialog() == DialogResult.OK)
            {
                lblInfoCrypt.Visible = false;
                ficherosEncriptados.Items.Clear();
                txtSalidaEnc.Text = DirectorioSalida.SelectedPath;
            }
        }
        //Boton de Encriptado
        private void btnEncript_Click(object sender, EventArgs e)
        {
            emptySelects.Clear();
            ficherosEncriptados.Items.Clear();
            DateTime inicial, final;
            int crypts = 0;
            //ENCRIPTADO
            if (radioEncript.Checked)
            {
                //Seleccion de directorio no puede estar vacío
                if ((txtEntradaEnc.Text != "") && (txtSalidaEnc.Text != ""))
                {
                    inicial = DateTime.Now;
                    foreach (string file in ficheros)
                    {
                        Encriptado(file, KEYCODE);
                        //Mostramos los ficheros encriptados
                        ficherosEncriptados.Items.Add(txtSalidaEnc.Text + @"\" + Path.GetFileNameWithoutExtension(file) + ".xxx");
                        crypts++;
                    }
                    final = DateTime.Now;
                    lblInfoCrypt.Visible = true;
                    ResultadoDeEncriptado(crypts, inicial.Ticks, final.Ticks);
                }
                else
                {
                    emptySelects.SetError(txtSalidaEnc, "Ruta vacía");
                }
            }
            //DESENCRIPTADO
            if (radioDecript.Checked)
            {
                //Seleccion de directorio no puede estar vacío
                if ((txtEntradaEnc.Text != "") && (txtSalidaEnc.Text != ""))
                {
                    inicial = DateTime.Now;
                    foreach (string file in ficheros)
                    {
                        Desencriptado(file, KEYCODE);
                        //Mostramos los ficheros des-encriptados
                        ficherosEncriptados.Items.Add(txtSalidaEnc.Text + @"\" + Path.GetFileNameWithoutExtension(file));
                        crypts++;
                    }
                    final = DateTime.Now;
                    lblInfoCrypt.Visible = true;
                    ResultadoDeEncriptado(crypts, inicial.Ticks, final.Ticks);
                }
                else
                {
                    emptySelects.SetError(txtSalidaEnc, "Ruta vacía");
                }
            }
        }
        
        //Cambio a encriptado
        private void radioEncript_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEncript.Checked)
            {
                emptySelects.Clear();
                ficherosParaEncriptar.Items.Clear();
                ficherosEncriptados.Items.Clear();
                txtEntradaEnc.Text = "";
                txtSalidaEnc.Text = "";
                groupBoxRutas.Visible = true;
                lblInfoCrypt.Visible = false;
                btnEncript.Text = "Encriptar";
                btnEncript.BackColor = Color.LightGreen;
            }
        }
        //Cambio a des-encriptado
        private void radioDecript_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDecript.Checked)
            {
                emptySelects.Clear();
                ficherosParaEncriptar.Items.Clear();
                ficherosEncriptados.Items.Clear();
                txtEntradaEnc.Text = "";
                txtSalidaEnc.Text = "";
                groupBoxRutas.Visible = true;
                lblInfoCrypt.Visible = false;
                btnEncript.Text = "Desencriptar";
                btnEncript.BackColor = Color.IndianRed;
            }
        }
    }
}
