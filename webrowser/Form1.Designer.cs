namespace webrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.lblURL);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(741, 8);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(47, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(13, 13);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(59, 13);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "Load URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(78, 10);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(640, 20);
            this.txtURL.TabIndex = 0;
            // 
            // webContent
            // 
            this.webContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webContent.Location = new System.Drawing.Point(0, 44);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.Size = new System.Drawing.Size(1203, 625);
            this.webContent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 669);
            this.Controls.Add(this.webContent);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webContent;
    }
}

