using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace icrypto
{
    partial class Form1
    {
        //Encriptado
        private void Encriptado(string file, byte KEYCODE)
        {
            var bytes = File.ReadAllBytes(file);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= KEYCODE;
            }
            File.WriteAllBytes(txtSalidaEnc.Text + @"\" + Path.GetFileName(file) + ".xxx", bytes);
        }
        //Desencriptado
        private void Desencriptado(string file, byte KEYCODE)
        {
            var bytes = File.ReadAllBytes(file);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= KEYCODE;
            }
            File.WriteAllBytes(txtSalidaEnc.Text + @"\" + Path.GetFileNameWithoutExtension(file), bytes);
        }
        //Muestra número y tiempo de duración de los archivos encriptados
        private void ResultadoDeEncriptado(int crypts, long inicial, long final)
        {
            float secs = (float)(inicial - final) / 10000000.0f;
            lblInfoCrypt.Text = string.Format("{0} archivos procesados en {1:F} segundos", crypts, secs);
        }
    }
}
