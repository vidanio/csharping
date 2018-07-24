namespace idatabase
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
            this.userContainer = new System.Windows.Forms.ListBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userContainer
            // 
            this.userContainer.FormattingEnabled = true;
            this.userContainer.Location = new System.Drawing.Point(199, 153);
            this.userContainer.Name = "userContainer";
            this.userContainer.Size = new System.Drawing.Size(398, 199);
            this.userContainer.TabIndex = 0;
            this.userContainer.SelectedIndexChanged += new System.EventHandler(this.userContainer_SelectedIndexChanged);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Location = new System.Drawing.Point(484, 61);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(484, 87);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(305, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(304, 89);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(304, 115);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(174, 20);
            this.txtPass.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(281, 66);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(256, 92);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(238, 118);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Contraseña";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(196, 369);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.userContainer);
            this.Name = "Form1";
            this.Text = "Manejo de Base de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userContainer;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblInfo;
    }
}

