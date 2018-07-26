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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.MiTabla = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // MiTabla
            // 
            this.MiTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_user,
            this.col_pass});
            this.MiTabla.FullRowSelect = true;
            this.MiTabla.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MiTabla.Location = new System.Drawing.Point(66, 156);
            this.MiTabla.Name = "MiTabla";
            this.MiTabla.Size = new System.Drawing.Size(656, 210);
            this.MiTabla.TabIndex = 10;
            this.MiTabla.UseCompatibleStateImageBehavior = false;
            this.MiTabla.View = System.Windows.Forms.View.Details;
            this.MiTabla.SelectedIndexChanged += new System.EventHandler(this.MiTabla_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            // 
            // col_user
            // 
            this.col_user.Text = "Usuario";
            this.col_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_user.Width = 236;
            // 
            // col_pass
            // 
            this.col_pass.Text = "Contraseña";
            this.col_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_pass.Width = 264;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(42, 17);
            this.lblInfo.Text = "Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(647, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Khaki;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(484, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MiTabla);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAnadir);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Manejo de Base de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.ListView MiTabla;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_user;
        private System.Windows.Forms.ColumnHeader col_pass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

