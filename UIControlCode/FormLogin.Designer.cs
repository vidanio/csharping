namespace UIControlCode
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.numServer = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblNumServer = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numServer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(89, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(173, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Introduzca los datos";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // numServer
            // 
            this.numServer.Location = new System.Drawing.Point(136, 57);
            this.numServer.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numServer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServer.Name = "numServer";
            this.numServer.Size = new System.Drawing.Size(61, 20);
            this.numServer.TabIndex = 0;
            this.numServer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::UIControlCode.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(168, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "   OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::UIControlCode.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(254, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 87);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(198, 20);
            this.txtMail.TabIndex = 1;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblNumServer
            // 
            this.lblNumServer.Image = global::UIControlCode.Properties.Resources.server20x20;
            this.lblNumServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumServer.Location = new System.Drawing.Point(16, 59);
            this.lblNumServer.Name = "lblNumServer";
            this.lblNumServer.Size = new System.Drawing.Size(109, 13);
            this.lblNumServer.TabIndex = 0;
            this.lblNumServer.Text = "Server Num ID:";
            this.lblNumServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMail
            // 
            this.lblMail.Image = global::UIControlCode.Properties.Resources.mail20x20;
            this.lblMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMail.Location = new System.Drawing.Point(16, 83);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(68, 24);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "E-mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPass
            // 
            this.lblPass.Image = global::UIControlCode.Properties.Resources.pass22x22;
            this.lblPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPass.Location = new System.Drawing.Point(16, 112);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(84, 30);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 202);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numServer);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNumServer);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 241);
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.NumericUpDown numServer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblNumServer;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPass;
    }
}