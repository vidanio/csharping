namespace filing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webClient1 = new System.Net.WebClient();
            this.SuspendLayout();
            // 
            // webClient1
            // 
            this.webClient1.BaseAddress = "";
            this.webClient1.CachePolicy = null;
            this.webClient1.Credentials = null;
            this.webClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient1.Encoding")));
            this.webClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient1.Headers")));
            this.webClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient1.QueryString")));
            this.webClient1.UseDefaultCredentials = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Net.WebClient webClient1;
    }
}

