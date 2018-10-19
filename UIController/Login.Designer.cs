namespace UIController
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblNumServer = new System.Windows.Forms.Label();
            this.numServer = new System.Windows.Forms.NumericUpDown();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numServer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumServer
            // 
            this.lblNumServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumServer.Image = ((System.Drawing.Image)(resources.GetObject("lblNumServer.Image")));
            this.lblNumServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumServer.Location = new System.Drawing.Point(16, 59);
            this.lblNumServer.Name = "lblNumServer";
            this.lblNumServer.Size = new System.Drawing.Size(109, 13);
            this.lblNumServer.TabIndex = 0;
            this.lblNumServer.Text = "Server Num ID:";
            this.lblNumServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numServer
            // 
            this.numServer.Location = new System.Drawing.Point(136, 57);
            this.numServer.Maximum = new decimal(new int[] {
            99999,
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
            this.numServer.TabIndex = 1;
            this.numServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Image = ((System.Drawing.Image)(resources.GetObject("lblMail.Image")));
            this.lblMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMail.Location = new System.Drawing.Point(16, 83);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(68, 24);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "E-mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 87);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(198, 20);
            this.txtMail.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Image = ((System.Drawing.Image)(resources.GetObject("lblPass.Image")));
            this.lblPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPass.Location = new System.Drawing.Point(16, 112);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(84, 30);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 118);
            this.txtPass.MaxLength = 20;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 20);
            this.txtPass.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(168, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "   OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(254, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(89, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(173, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Introduzca los datos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 202);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.numServer);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNumServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 241);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.numServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumServer;
        private System.Windows.Forms.NumericUpDown numServer;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
    }
}