namespace updown
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
            this.webCli = new System.Net.WebClient();
            this.SuspendLayout();
            // 
            // webCli
            // 
            this.webCli.BaseAddress = "";
            this.webCli.CachePolicy = null;
            this.webCli.Credentials = null;
            this.webCli.Encoding = ((System.Text.Encoding)(resources.GetObject("webCli.Encoding")));
            this.webCli.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webCli.Headers")));
            this.webCli.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webCli.QueryString")));
            this.webCli.UseDefaultCredentials = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpDown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Net.WebClient webCli;
    }
}

