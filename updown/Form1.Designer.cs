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
            this.folderBrwDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.grpUpload = new System.Windows.Forms.GroupBox();
            this.txtUpLogging = new System.Windows.Forms.TextBox();
            this.lblUpInfo = new System.Windows.Forms.Label();
            this.progbarUpload = new System.Windows.Forms.ProgressBar();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lblUpURL = new System.Windows.Forms.Label();
            this.txtUploadURL = new System.Windows.Forms.TextBox();
            this.txtUpFile = new System.Windows.Forms.TextBox();
            this.grpDownload = new System.Windows.Forms.GroupBox();
            this.txtDownLogging = new System.Windows.Forms.TextBox();
            this.lblDownInfo = new System.Windows.Forms.Label();
            this.txtDownFolder = new System.Windows.Forms.TextBox();
            this.progbarDownload = new System.Windows.Forms.ProgressBar();
            this.txtDownURLFile = new System.Windows.Forms.TextBox();
            this.lblDown = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.grpUpload.SuspendLayout();
            this.grpDownload.SuspendLayout();
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
            // openFileDlg
            // 
            this.openFileDlg.Filter = "All Files|*.*";
            // 
            // grpUpload
            // 
            this.grpUpload.Controls.Add(this.txtUpLogging);
            this.grpUpload.Controls.Add(this.lblUpInfo);
            this.grpUpload.Controls.Add(this.progbarUpload);
            this.grpUpload.Controls.Add(this.btnUploadFile);
            this.grpUpload.Controls.Add(this.lblUpURL);
            this.grpUpload.Controls.Add(this.txtUploadURL);
            this.grpUpload.Controls.Add(this.txtUpFile);
            this.grpUpload.Location = new System.Drawing.Point(12, 12);
            this.grpUpload.Name = "grpUpload";
            this.grpUpload.Size = new System.Drawing.Size(447, 433);
            this.grpUpload.TabIndex = 0;
            this.grpUpload.TabStop = false;
            this.grpUpload.Text = "Upload";
            // 
            // txtUpLogging
            // 
            this.txtUpLogging.Location = new System.Drawing.Point(36, 230);
            this.txtUpLogging.Multiline = true;
            this.txtUpLogging.Name = "txtUpLogging";
            this.txtUpLogging.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpLogging.Size = new System.Drawing.Size(376, 183);
            this.txtUpLogging.TabIndex = 6;
            // 
            // lblUpInfo
            // 
            this.lblUpInfo.AutoSize = true;
            this.lblUpInfo.Location = new System.Drawing.Point(36, 177);
            this.lblUpInfo.Name = "lblUpInfo";
            this.lblUpInfo.Size = new System.Drawing.Size(37, 13);
            this.lblUpInfo.TabIndex = 5;
            this.lblUpInfo.Text = "(none)";
            // 
            // progbarUpload
            // 
            this.progbarUpload.Location = new System.Drawing.Point(36, 196);
            this.progbarUpload.Name = "progbarUpload";
            this.progbarUpload.Size = new System.Drawing.Size(376, 15);
            this.progbarUpload.Step = 1;
            this.progbarUpload.TabIndex = 4;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadFile.Location = new System.Drawing.Point(36, 121);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(138, 29);
            this.btnUploadFile.TabIndex = 3;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            // 
            // lblUpURL
            // 
            this.lblUpURL.AutoSize = true;
            this.lblUpURL.Location = new System.Drawing.Point(33, 79);
            this.lblUpURL.Name = "lblUpURL";
            this.lblUpURL.Size = new System.Drawing.Size(66, 13);
            this.lblUpURL.TabIndex = 2;
            this.lblUpURL.Text = "Upload URL";
            // 
            // txtUploadURL
            // 
            this.txtUploadURL.Location = new System.Drawing.Point(109, 76);
            this.txtUploadURL.Name = "txtUploadURL";
            this.txtUploadURL.Size = new System.Drawing.Size(303, 20);
            this.txtUploadURL.TabIndex = 1;
            this.txtUploadURL.Text = "http://";
            // 
            // txtUpFile
            // 
            this.txtUpFile.Location = new System.Drawing.Point(36, 38);
            this.txtUpFile.Name = "txtUpFile";
            this.txtUpFile.ReadOnly = true;
            this.txtUpFile.Size = new System.Drawing.Size(376, 20);
            this.txtUpFile.TabIndex = 0;
            this.txtUpFile.TabStop = false;
            this.txtUpFile.Text = "(Choose Upload File...)";
            this.txtUpFile.Click += new System.EventHandler(this.txtUpFile_Click);
            // 
            // grpDownload
            // 
            this.grpDownload.Controls.Add(this.txtDownLogging);
            this.grpDownload.Controls.Add(this.lblDownInfo);
            this.grpDownload.Controls.Add(this.txtDownFolder);
            this.grpDownload.Controls.Add(this.progbarDownload);
            this.grpDownload.Controls.Add(this.txtDownURLFile);
            this.grpDownload.Controls.Add(this.lblDown);
            this.grpDownload.Controls.Add(this.btnDownload);
            this.grpDownload.Location = new System.Drawing.Point(472, 12);
            this.grpDownload.Name = "grpDownload";
            this.grpDownload.Size = new System.Drawing.Size(447, 433);
            this.grpDownload.TabIndex = 0;
            this.grpDownload.TabStop = false;
            this.grpDownload.Text = "Download";
            // 
            // txtDownLogging
            // 
            this.txtDownLogging.Location = new System.Drawing.Point(30, 230);
            this.txtDownLogging.Multiline = true;
            this.txtDownLogging.Name = "txtDownLogging";
            this.txtDownLogging.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDownLogging.Size = new System.Drawing.Size(376, 183);
            this.txtDownLogging.TabIndex = 6;
            // 
            // lblDownInfo
            // 
            this.lblDownInfo.AutoSize = true;
            this.lblDownInfo.Location = new System.Drawing.Point(30, 177);
            this.lblDownInfo.Name = "lblDownInfo";
            this.lblDownInfo.Size = new System.Drawing.Size(37, 13);
            this.lblDownInfo.TabIndex = 5;
            this.lblDownInfo.Text = "(none)";
            // 
            // txtDownFolder
            // 
            this.txtDownFolder.Location = new System.Drawing.Point(30, 38);
            this.txtDownFolder.Name = "txtDownFolder";
            this.txtDownFolder.ReadOnly = true;
            this.txtDownFolder.Size = new System.Drawing.Size(376, 20);
            this.txtDownFolder.TabIndex = 0;
            this.txtDownFolder.TabStop = false;
            this.txtDownFolder.Text = "(Choose Download Folder...)";
            this.txtDownFolder.Click += new System.EventHandler(this.txtDownFolder_Click);
            // 
            // progbarDownload
            // 
            this.progbarDownload.Location = new System.Drawing.Point(30, 196);
            this.progbarDownload.Name = "progbarDownload";
            this.progbarDownload.Size = new System.Drawing.Size(376, 15);
            this.progbarDownload.Step = 1;
            this.progbarDownload.TabIndex = 4;
            // 
            // txtDownURLFile
            // 
            this.txtDownURLFile.Location = new System.Drawing.Point(113, 72);
            this.txtDownURLFile.Name = "txtDownURLFile";
            this.txtDownURLFile.Size = new System.Drawing.Size(293, 20);
            this.txtDownURLFile.TabIndex = 1;
            this.txtDownURLFile.Text = "http://";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(27, 75);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(80, 13);
            this.lblDown.TabIndex = 2;
            this.lblDown.Text = "Download URL";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Location = new System.Drawing.Point(30, 121);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(131, 29);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download File";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 457);
            this.Controls.Add(this.grpDownload);
            this.Controls.Add(this.grpUpload);
            this.Location = new System.Drawing.Point(947, 496);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(947, 496);
            this.MinimumSize = new System.Drawing.Size(947, 496);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpDown";
            this.grpUpload.ResumeLayout(false);
            this.grpUpload.PerformLayout();
            this.grpDownload.ResumeLayout(false);
            this.grpDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Net.WebClient webCli;
        private System.Windows.Forms.FolderBrowserDialog folderBrwDlg;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.GroupBox grpUpload;
        private System.Windows.Forms.GroupBox grpDownload;
        private System.Windows.Forms.TextBox txtUpLogging;
        private System.Windows.Forms.Label lblUpInfo;
        private System.Windows.Forms.ProgressBar progbarUpload;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label lblUpURL;
        private System.Windows.Forms.TextBox txtUploadURL;
        private System.Windows.Forms.TextBox txtUpFile;
        private System.Windows.Forms.TextBox txtDownLogging;
        private System.Windows.Forms.Label lblDownInfo;
        private System.Windows.Forms.TextBox txtDownFolder;
        private System.Windows.Forms.ProgressBar progbarDownload;
        private System.Windows.Forms.TextBox txtDownURLFile;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Button btnDownload;
    }
}

