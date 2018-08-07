namespace iupdown
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
            this.gprSubida = new System.Windows.Forms.GroupBox();
            this.barSubida = new System.Windows.Forms.ProgressBar();
            this.btnSubida = new System.Windows.Forms.Button();
            this.listSubidos = new System.Windows.Forms.ListBox();
            this.lblsubida = new System.Windows.Forms.Label();
            this.txtUploadURL = new System.Windows.Forms.TextBox();
            this.txtFileUpload = new System.Windows.Forms.TextBox();
            this.wClient = new System.Net.WebClient();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpDescarga = new System.Windows.Forms.GroupBox();
            this.listBajados = new System.Windows.Forms.ListBox();
            this.barBajada = new System.Windows.Forms.ProgressBar();
            this.btnBajada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBajada = new System.Windows.Forms.TextBox();
            this.txtDirBajada = new System.Windows.Forms.TextBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gprSubida.SuspendLayout();
            this.grpDescarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprSubida
            // 
            this.gprSubida.Controls.Add(this.barSubida);
            this.gprSubida.Controls.Add(this.btnSubida);
            this.gprSubida.Controls.Add(this.listSubidos);
            this.gprSubida.Controls.Add(this.lblsubida);
            this.gprSubida.Controls.Add(this.txtUploadURL);
            this.gprSubida.Controls.Add(this.txtFileUpload);
            this.gprSubida.Location = new System.Drawing.Point(25, 24);
            this.gprSubida.Name = "gprSubida";
            this.gprSubida.Size = new System.Drawing.Size(375, 396);
            this.gprSubida.TabIndex = 0;
            this.gprSubida.TabStop = false;
            this.gprSubida.Text = "Subida";
            // 
            // barSubida
            // 
            this.barSubida.Location = new System.Drawing.Point(34, 161);
            this.barSubida.Name = "barSubida";
            this.barSubida.Size = new System.Drawing.Size(314, 16);
            this.barSubida.Step = 1;
            this.barSubida.TabIndex = 5;
            // 
            // btnSubida
            // 
            this.btnSubida.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubida.Location = new System.Drawing.Point(158, 117);
            this.btnSubida.Name = "btnSubida";
            this.btnSubida.Size = new System.Drawing.Size(75, 23);
            this.btnSubida.TabIndex = 4;
            this.btnSubida.Text = "Subir";
            this.btnSubida.UseVisualStyleBackColor = false;
            this.btnSubida.Click += new System.EventHandler(this.btnSubida_Click);
            // 
            // listSubidos
            // 
            this.listSubidos.FormattingEnabled = true;
            this.listSubidos.Location = new System.Drawing.Point(34, 183);
            this.listSubidos.Name = "listSubidos";
            this.listSubidos.Size = new System.Drawing.Size(314, 186);
            this.listSubidos.TabIndex = 3;
            // 
            // lblsubida
            // 
            this.lblsubida.AutoSize = true;
            this.lblsubida.Location = new System.Drawing.Point(31, 75);
            this.lblsubida.Name = "lblsubida";
            this.lblsubida.Size = new System.Drawing.Size(97, 13);
            this.lblsubida.TabIndex = 2;
            this.lblsubida.Text = "Servidor de Subida";
            // 
            // txtUploadURL
            // 
            this.txtUploadURL.Location = new System.Drawing.Point(34, 91);
            this.txtUploadURL.Name = "txtUploadURL";
            this.txtUploadURL.Size = new System.Drawing.Size(314, 20);
            this.txtUploadURL.TabIndex = 1;
            this.txtUploadURL.Text = "http://";
            // 
            // txtFileUpload
            // 
            this.txtFileUpload.Location = new System.Drawing.Point(34, 45);
            this.txtFileUpload.Name = "txtFileUpload";
            this.txtFileUpload.Size = new System.Drawing.Size(314, 20);
            this.txtFileUpload.TabIndex = 0;
            this.txtFileUpload.Text = "(Fichero para Subir)";
            this.txtFileUpload.Click += new System.EventHandler(this.txtFileUpload_Click);
            // 
            // wClient
            // 
            this.wClient.BaseAddress = "";
            this.wClient.CachePolicy = null;
            this.wClient.Credentials = null;
            this.wClient.Encoding = ((System.Text.Encoding)(resources.GetObject("wClient.Encoding")));
            this.wClient.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("wClient.Headers")));
            this.wClient.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("wClient.QueryString")));
            this.wClient.UseDefaultCredentials = false;
            this.wClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.wClient_DownloadFileCompleted);
            this.wClient.UploadFileCompleted += new System.Net.UploadFileCompletedEventHandler(this.wClient_UploadFileCompleted);
            this.wClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.wClient_DownloadProgressChanged);
            this.wClient.UploadProgressChanged += new System.Net.UploadProgressChangedEventHandler(this.wClient_UploadProgressChanged);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // grpDescarga
            // 
            this.grpDescarga.Controls.Add(this.listBajados);
            this.grpDescarga.Controls.Add(this.barBajada);
            this.grpDescarga.Controls.Add(this.btnBajada);
            this.grpDescarga.Controls.Add(this.label1);
            this.grpDescarga.Controls.Add(this.txtBajada);
            this.grpDescarga.Controls.Add(this.txtDirBajada);
            this.grpDescarga.Location = new System.Drawing.Point(406, 24);
            this.grpDescarga.Name = "grpDescarga";
            this.grpDescarga.Size = new System.Drawing.Size(366, 396);
            this.grpDescarga.TabIndex = 1;
            this.grpDescarga.TabStop = false;
            this.grpDescarga.Text = "Descarga";
            // 
            // listBajados
            // 
            this.listBajados.FormattingEnabled = true;
            this.listBajados.Location = new System.Drawing.Point(19, 183);
            this.listBajados.Name = "listBajados";
            this.listBajados.Size = new System.Drawing.Size(325, 186);
            this.listBajados.TabIndex = 5;
            // 
            // barBajada
            // 
            this.barBajada.Location = new System.Drawing.Point(19, 161);
            this.barBajada.Name = "barBajada";
            this.barBajada.Size = new System.Drawing.Size(325, 16);
            this.barBajada.TabIndex = 4;
            // 
            // btnBajada
            // 
            this.btnBajada.BackColor = System.Drawing.Color.Khaki;
            this.btnBajada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajada.Location = new System.Drawing.Point(156, 117);
            this.btnBajada.Name = "btnBajada";
            this.btnBajada.Size = new System.Drawing.Size(75, 23);
            this.btnBajada.TabIndex = 3;
            this.btnBajada.Text = "Descargar";
            this.btnBajada.UseVisualStyleBackColor = false;
            this.btnBajada.Click += new System.EventHandler(this.btnBajada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fichero de Bajada";
            // 
            // txtBajada
            // 
            this.txtBajada.Location = new System.Drawing.Point(19, 91);
            this.txtBajada.Name = "txtBajada";
            this.txtBajada.Size = new System.Drawing.Size(325, 20);
            this.txtBajada.TabIndex = 1;
            this.txtBajada.Text = "http://";
            // 
            // txtDirBajada
            // 
            this.txtDirBajada.Location = new System.Drawing.Point(19, 45);
            this.txtDirBajada.Name = "txtDirBajada";
            this.txtDirBajada.Size = new System.Drawing.Size(325, 20);
            this.txtDirBajada.TabIndex = 0;
            this.txtDirBajada.Text = "(Carpeta de Descarga)";
            this.txtDirBajada.Click += new System.EventHandler(this.txtDirBajada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpDescarga);
            this.Controls.Add(this.gprSubida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gprSubida.ResumeLayout(false);
            this.gprSubida.PerformLayout();
            this.grpDescarga.ResumeLayout(false);
            this.grpDescarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gprSubida;
        private System.Windows.Forms.TextBox txtUploadURL;
        private System.Windows.Forms.TextBox txtFileUpload;
        private System.Net.WebClient wClient;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label lblsubida;
        private System.Windows.Forms.ListBox listSubidos;
        private System.Windows.Forms.Button btnSubida;
        private System.Windows.Forms.ProgressBar barSubida;
        private System.Windows.Forms.GroupBox grpDescarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBajada;
        private System.Windows.Forms.TextBox txtDirBajada;
        private System.Windows.Forms.ListBox listBajados;
        private System.Windows.Forms.ProgressBar barBajada;
        private System.Windows.Forms.Button btnBajada;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}

