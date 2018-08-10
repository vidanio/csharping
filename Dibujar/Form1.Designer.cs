namespace Dibujar
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
            this.btnDibuja = new System.Windows.Forms.Button();
            this.pictBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibuja
            // 
            this.btnDibuja.Location = new System.Drawing.Point(713, 12);
            this.btnDibuja.Name = "btnDibuja";
            this.btnDibuja.Size = new System.Drawing.Size(75, 23);
            this.btnDibuja.TabIndex = 0;
            this.btnDibuja.Text = "Dibuja";
            this.btnDibuja.UseVisualStyleBackColor = true;
            this.btnDibuja.Click += new System.EventHandler(this.btnDibuja_Click);
            // 
            // pictBox
            // 
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Location = new System.Drawing.Point(12, 12);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(695, 426);
            this.pictBox.TabIndex = 1;
            this.pictBox.TabStop = false;
            this.pictBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.btnDibuja);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dibujar";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDibuja;
        private System.Windows.Forms.PictureBox pictBox;
    }
}

