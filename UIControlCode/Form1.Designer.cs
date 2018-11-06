namespace UIControlCode
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
            this.components = new System.ComponentModel.Container();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpEmisor1 = new System.Windows.Forms.GroupBox();
            this.lblText1E = new System.Windows.Forms.Label();
            this.lblSmartkey1E = new System.Windows.Forms.Label();
            this.lblSrt1E = new System.Windows.Forms.Label();
            this.lblSource1E = new System.Windows.Forms.Label();
            this.txtSmartkey1E = new System.Windows.Forms.TextBox();
            this.txtSource1E = new System.Windows.Forms.TextBox();
            this.numServID1E = new System.Windows.Forms.NumericUpDown();
            this.btnStop1E = new System.Windows.Forms.Button();
            this.btnStart1E = new System.Windows.Forms.Button();
            this.grpEmisor2 = new System.Windows.Forms.GroupBox();
            this.lblText2E = new System.Windows.Forms.Label();
            this.lblSmartkey2E = new System.Windows.Forms.Label();
            this.lblSrt2E = new System.Windows.Forms.Label();
            this.lblSource2E = new System.Windows.Forms.Label();
            this.txtSmartkey2E = new System.Windows.Forms.TextBox();
            this.txtSource2E = new System.Windows.Forms.TextBox();
            this.numServID2E = new System.Windows.Forms.NumericUpDown();
            this.btnStop2E = new System.Windows.Forms.Button();
            this.btnStart2E = new System.Windows.Forms.Button();
            this.grpReceptor1 = new System.Windows.Forms.GroupBox();
            this.lblText1D = new System.Windows.Forms.Label();
            this.lblSmartkey1D = new System.Windows.Forms.Label();
            this.lblSrt1D = new System.Windows.Forms.Label();
            this.lblcopypaste1D = new System.Windows.Forms.Label();
            this.lblTCPlocal1D = new System.Windows.Forms.Label();
            this.txtSmartkey1D = new System.Windows.Forms.TextBox();
            this.numServID1D = new System.Windows.Forms.NumericUpDown();
            this.btnStop1D = new System.Windows.Forms.Button();
            this.btnStart1D = new System.Windows.Forms.Button();
            this.grpReceptor2 = new System.Windows.Forms.GroupBox();
            this.lblText2D = new System.Windows.Forms.Label();
            this.lblSmartkey2D = new System.Windows.Forms.Label();
            this.lblSrt2D = new System.Windows.Forms.Label();
            this.lblcopypaste2D = new System.Windows.Forms.Label();
            this.lblTCPlocal2D = new System.Windows.Forms.Label();
            this.txtSmartkey2D = new System.Windows.Forms.TextBox();
            this.numServID2D = new System.Windows.Forms.NumericUpDown();
            this.btnStop2D = new System.Windows.Forms.Button();
            this.btnStart2D = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.timerMDNS = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.grpEmisor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID1E)).BeginInit();
            this.grpEmisor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID2E)).BeginInit();
            this.grpReceptor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID1D)).BeginInit();
            this.grpReceptor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID2D)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(1000, 41);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(392, 551);
            this.txtDebug.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1404, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.controlarEquipoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.archivoToolStripMenuItem.Text = "Conectar";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.logInToolStripMenuItem.Text = "Smart SRT Server";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // controlarEquipoToolStripMenuItem
            // 
            this.controlarEquipoToolStripMenuItem.Name = "controlarEquipoToolStripMenuItem";
            this.controlarEquipoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.controlarEquipoToolStripMenuItem.Text = "Dispostivos Locales";
            this.controlarEquipoToolStripMenuItem.Click += new System.EventHandler(this.controlarEquipoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblMsg});
            this.status.Location = new System.Drawing.Point(0, 619);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1404, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // statusLblMsg
            // 
            this.statusLblMsg.Name = "statusLblMsg";
            this.statusLblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grpEmisor1
            // 
            this.grpEmisor1.Controls.Add(this.lblText1E);
            this.grpEmisor1.Controls.Add(this.lblSmartkey1E);
            this.grpEmisor1.Controls.Add(this.lblSrt1E);
            this.grpEmisor1.Controls.Add(this.lblSource1E);
            this.grpEmisor1.Controls.Add(this.txtSmartkey1E);
            this.grpEmisor1.Controls.Add(this.txtSource1E);
            this.grpEmisor1.Controls.Add(this.numServID1E);
            this.grpEmisor1.Controls.Add(this.btnStop1E);
            this.grpEmisor1.Controls.Add(this.btnStart1E);
            this.grpEmisor1.Location = new System.Drawing.Point(56, 48);
            this.grpEmisor1.Name = "grpEmisor1";
            this.grpEmisor1.Size = new System.Drawing.Size(412, 256);
            this.grpEmisor1.TabIndex = 6;
            this.grpEmisor1.TabStop = false;
            this.grpEmisor1.Text = "Emisor 1";
            // 
            // lblText1E
            // 
            this.lblText1E.Location = new System.Drawing.Point(30, 203);
            this.lblText1E.Name = "lblText1E";
            this.lblText1E.Size = new System.Drawing.Size(341, 23);
            this.lblText1E.TabIndex = 3;
            this.lblText1E.Text = "(none)";
            this.lblText1E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmartkey1E
            // 
            this.lblSmartkey1E.AutoSize = true;
            this.lblSmartkey1E.Location = new System.Drawing.Point(168, 103);
            this.lblSmartkey1E.Name = "lblSmartkey1E";
            this.lblSmartkey1E.Size = new System.Drawing.Size(55, 13);
            this.lblSmartkey1E.TabIndex = 3;
            this.lblSmartkey1E.Text = "SmartKey:";
            // 
            // lblSrt1E
            // 
            this.lblSrt1E.AutoSize = true;
            this.lblSrt1E.Location = new System.Drawing.Point(45, 100);
            this.lblSrt1E.Name = "lblSrt1E";
            this.lblSrt1E.Size = new System.Drawing.Size(55, 13);
            this.lblSrt1E.TabIndex = 3;
            this.lblSrt1E.Text = "Server ID:";
            // 
            // lblSource1E
            // 
            this.lblSource1E.AutoSize = true;
            this.lblSource1E.Location = new System.Drawing.Point(34, 42);
            this.lblSource1E.Name = "lblSource1E";
            this.lblSource1E.Size = new System.Drawing.Size(66, 13);
            this.lblSource1E.TabIndex = 3;
            this.lblSource1E.Text = "URL Origen:";
            // 
            // txtSmartkey1E
            // 
            this.txtSmartkey1E.Location = new System.Drawing.Point(229, 100);
            this.txtSmartkey1E.MaxLength = 16;
            this.txtSmartkey1E.Name = "txtSmartkey1E";
            this.txtSmartkey1E.Size = new System.Drawing.Size(142, 20);
            this.txtSmartkey1E.TabIndex = 2;
            // 
            // txtSource1E
            // 
            this.txtSource1E.Location = new System.Drawing.Point(106, 39);
            this.txtSource1E.MaxLength = 255;
            this.txtSource1E.Name = "txtSource1E";
            this.txtSource1E.Size = new System.Drawing.Size(265, 20);
            this.txtSource1E.TabIndex = 0;
            // 
            // numServID1E
            // 
            this.numServID1E.Location = new System.Drawing.Point(106, 98);
            this.numServID1E.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numServID1E.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServID1E.Name = "numServID1E";
            this.numServID1E.Size = new System.Drawing.Size(56, 20);
            this.numServID1E.TabIndex = 1;
            this.numServID1E.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServID1E.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop1E
            // 
            this.btnStop1E.Location = new System.Drawing.Point(171, 149);
            this.btnStop1E.Name = "btnStop1E";
            this.btnStop1E.Size = new System.Drawing.Size(75, 23);
            this.btnStop1E.TabIndex = 0;
            this.btnStop1E.TabStop = false;
            this.btnStop1E.Text = "Parar";
            this.btnStop1E.UseVisualStyleBackColor = true;
            this.btnStop1E.Click += new System.EventHandler(this.btnStop1E_Click);
            // 
            // btnStart1E
            // 
            this.btnStart1E.Location = new System.Drawing.Point(159, 149);
            this.btnStart1E.Name = "btnStart1E";
            this.btnStart1E.Size = new System.Drawing.Size(75, 23);
            this.btnStart1E.TabIndex = 0;
            this.btnStart1E.TabStop = false;
            this.btnStart1E.Text = "Emitir";
            this.btnStart1E.UseVisualStyleBackColor = true;
            this.btnStart1E.Click += new System.EventHandler(this.btnStart1E_Click);
            // 
            // grpEmisor2
            // 
            this.grpEmisor2.Controls.Add(this.lblText2E);
            this.grpEmisor2.Controls.Add(this.lblSmartkey2E);
            this.grpEmisor2.Controls.Add(this.lblSrt2E);
            this.grpEmisor2.Controls.Add(this.lblSource2E);
            this.grpEmisor2.Controls.Add(this.txtSmartkey2E);
            this.grpEmisor2.Controls.Add(this.txtSource2E);
            this.grpEmisor2.Controls.Add(this.numServID2E);
            this.grpEmisor2.Controls.Add(this.btnStop2E);
            this.grpEmisor2.Controls.Add(this.btnStart2E);
            this.grpEmisor2.Location = new System.Drawing.Point(521, 48);
            this.grpEmisor2.Name = "grpEmisor2";
            this.grpEmisor2.Size = new System.Drawing.Size(412, 256);
            this.grpEmisor2.TabIndex = 6;
            this.grpEmisor2.TabStop = false;
            this.grpEmisor2.Text = "Emisor 2";
            // 
            // lblText2E
            // 
            this.lblText2E.Location = new System.Drawing.Point(30, 203);
            this.lblText2E.Name = "lblText2E";
            this.lblText2E.Size = new System.Drawing.Size(341, 23);
            this.lblText2E.TabIndex = 3;
            this.lblText2E.Text = "(none)";
            this.lblText2E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmartkey2E
            // 
            this.lblSmartkey2E.AutoSize = true;
            this.lblSmartkey2E.Location = new System.Drawing.Point(168, 103);
            this.lblSmartkey2E.Name = "lblSmartkey2E";
            this.lblSmartkey2E.Size = new System.Drawing.Size(55, 13);
            this.lblSmartkey2E.TabIndex = 3;
            this.lblSmartkey2E.Text = "SmartKey:";
            // 
            // lblSrt2E
            // 
            this.lblSrt2E.AutoSize = true;
            this.lblSrt2E.Location = new System.Drawing.Point(45, 100);
            this.lblSrt2E.Name = "lblSrt2E";
            this.lblSrt2E.Size = new System.Drawing.Size(55, 13);
            this.lblSrt2E.TabIndex = 3;
            this.lblSrt2E.Text = "Server ID:";
            // 
            // lblSource2E
            // 
            this.lblSource2E.AutoSize = true;
            this.lblSource2E.Location = new System.Drawing.Point(34, 42);
            this.lblSource2E.Name = "lblSource2E";
            this.lblSource2E.Size = new System.Drawing.Size(66, 13);
            this.lblSource2E.TabIndex = 3;
            this.lblSource2E.Text = "URL Origen:";
            // 
            // txtSmartkey2E
            // 
            this.txtSmartkey2E.Location = new System.Drawing.Point(229, 100);
            this.txtSmartkey2E.MaxLength = 16;
            this.txtSmartkey2E.Name = "txtSmartkey2E";
            this.txtSmartkey2E.Size = new System.Drawing.Size(142, 20);
            this.txtSmartkey2E.TabIndex = 2;
            // 
            // txtSource2E
            // 
            this.txtSource2E.Location = new System.Drawing.Point(106, 39);
            this.txtSource2E.MaxLength = 255;
            this.txtSource2E.Name = "txtSource2E";
            this.txtSource2E.Size = new System.Drawing.Size(265, 20);
            this.txtSource2E.TabIndex = 0;
            // 
            // numServID2E
            // 
            this.numServID2E.Location = new System.Drawing.Point(106, 98);
            this.numServID2E.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numServID2E.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServID2E.Name = "numServID2E";
            this.numServID2E.Size = new System.Drawing.Size(56, 20);
            this.numServID2E.TabIndex = 1;
            this.numServID2E.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServID2E.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop2E
            // 
            this.btnStop2E.Location = new System.Drawing.Point(171, 149);
            this.btnStop2E.Name = "btnStop2E";
            this.btnStop2E.Size = new System.Drawing.Size(75, 23);
            this.btnStop2E.TabIndex = 0;
            this.btnStop2E.TabStop = false;
            this.btnStop2E.Text = "Parar";
            this.btnStop2E.UseVisualStyleBackColor = true;
            this.btnStop2E.Click += new System.EventHandler(this.btnStop2E_Click);
            // 
            // btnStart2E
            // 
            this.btnStart2E.Location = new System.Drawing.Point(159, 149);
            this.btnStart2E.Name = "btnStart2E";
            this.btnStart2E.Size = new System.Drawing.Size(75, 23);
            this.btnStart2E.TabIndex = 0;
            this.btnStart2E.TabStop = false;
            this.btnStart2E.Text = "Emitir";
            this.btnStart2E.UseVisualStyleBackColor = true;
            this.btnStart2E.Click += new System.EventHandler(this.btnStart2E_Click);
            // 
            // grpReceptor1
            // 
            this.grpReceptor1.Controls.Add(this.lblText1D);
            this.grpReceptor1.Controls.Add(this.lblSmartkey1D);
            this.grpReceptor1.Controls.Add(this.lblSrt1D);
            this.grpReceptor1.Controls.Add(this.lblcopypaste1D);
            this.grpReceptor1.Controls.Add(this.lblTCPlocal1D);
            this.grpReceptor1.Controls.Add(this.txtSmartkey1D);
            this.grpReceptor1.Controls.Add(this.numServID1D);
            this.grpReceptor1.Controls.Add(this.btnStop1D);
            this.grpReceptor1.Controls.Add(this.btnStart1D);
            this.grpReceptor1.Location = new System.Drawing.Point(56, 336);
            this.grpReceptor1.Name = "grpReceptor1";
            this.grpReceptor1.Size = new System.Drawing.Size(412, 256);
            this.grpReceptor1.TabIndex = 6;
            this.grpReceptor1.TabStop = false;
            this.grpReceptor1.Text = "Receptor 1";
            // 
            // lblText1D
            // 
            this.lblText1D.Location = new System.Drawing.Point(30, 203);
            this.lblText1D.Name = "lblText1D";
            this.lblText1D.Size = new System.Drawing.Size(341, 23);
            this.lblText1D.TabIndex = 3;
            this.lblText1D.Text = "(none)";
            this.lblText1D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmartkey1D
            // 
            this.lblSmartkey1D.AutoSize = true;
            this.lblSmartkey1D.Location = new System.Drawing.Point(168, 52);
            this.lblSmartkey1D.Name = "lblSmartkey1D";
            this.lblSmartkey1D.Size = new System.Drawing.Size(55, 13);
            this.lblSmartkey1D.TabIndex = 3;
            this.lblSmartkey1D.Text = "SmartKey:";
            // 
            // lblSrt1D
            // 
            this.lblSrt1D.AutoSize = true;
            this.lblSrt1D.Location = new System.Drawing.Point(45, 49);
            this.lblSrt1D.Name = "lblSrt1D";
            this.lblSrt1D.Size = new System.Drawing.Size(55, 13);
            this.lblSrt1D.TabIndex = 3;
            this.lblSrt1D.Text = "Server ID:";
            // 
            // lblcopypaste1D
            // 
            this.lblcopypaste1D.AutoSize = true;
            this.lblcopypaste1D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcopypaste1D.Location = new System.Drawing.Point(190, 105);
            this.lblcopypaste1D.Name = "lblcopypaste1D";
            this.lblcopypaste1D.Size = new System.Drawing.Size(74, 13);
            this.lblcopypaste1D.TabIndex = 3;
            this.lblcopypaste1D.Text = "copiar y pegar";
            this.lblcopypaste1D.Click += new System.EventHandler(this.lblcopypaste1D_Click);
            // 
            // lblTCPlocal1D
            // 
            this.lblTCPlocal1D.AutoSize = true;
            this.lblTCPlocal1D.Location = new System.Drawing.Point(114, 105);
            this.lblTCPlocal1D.Name = "lblTCPlocal1D";
            this.lblTCPlocal1D.Size = new System.Drawing.Size(60, 13);
            this.lblTCPlocal1D.TabIndex = 3;
            this.lblTCPlocal1D.Text = "TCP Local:";
            // 
            // txtSmartkey1D
            // 
            this.txtSmartkey1D.Location = new System.Drawing.Point(229, 49);
            this.txtSmartkey1D.MaxLength = 16;
            this.txtSmartkey1D.Name = "txtSmartkey1D";
            this.txtSmartkey1D.Size = new System.Drawing.Size(142, 20);
            this.txtSmartkey1D.TabIndex = 1;
            // 
            // numServID1D
            // 
            this.numServID1D.Location = new System.Drawing.Point(106, 47);
            this.numServID1D.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numServID1D.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServID1D.Name = "numServID1D";
            this.numServID1D.Size = new System.Drawing.Size(56, 20);
            this.numServID1D.TabIndex = 0;
            this.numServID1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServID1D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop1D
            // 
            this.btnStop1D.Location = new System.Drawing.Point(171, 149);
            this.btnStop1D.Name = "btnStop1D";
            this.btnStop1D.Size = new System.Drawing.Size(75, 23);
            this.btnStop1D.TabIndex = 0;
            this.btnStop1D.TabStop = false;
            this.btnStop1D.Text = "Parar";
            this.btnStop1D.UseVisualStyleBackColor = true;
            this.btnStop1D.Click += new System.EventHandler(this.btnStop1D_Click);
            // 
            // btnStart1D
            // 
            this.btnStart1D.Location = new System.Drawing.Point(159, 149);
            this.btnStart1D.Name = "btnStart1D";
            this.btnStart1D.Size = new System.Drawing.Size(75, 23);
            this.btnStart1D.TabIndex = 0;
            this.btnStart1D.TabStop = false;
            this.btnStart1D.Text = "Emitir";
            this.btnStart1D.UseVisualStyleBackColor = true;
            this.btnStart1D.Click += new System.EventHandler(this.btnStart1D_Click);
            // 
            // grpReceptor2
            // 
            this.grpReceptor2.Controls.Add(this.lblText2D);
            this.grpReceptor2.Controls.Add(this.lblSmartkey2D);
            this.grpReceptor2.Controls.Add(this.lblSrt2D);
            this.grpReceptor2.Controls.Add(this.lblcopypaste2D);
            this.grpReceptor2.Controls.Add(this.lblTCPlocal2D);
            this.grpReceptor2.Controls.Add(this.txtSmartkey2D);
            this.grpReceptor2.Controls.Add(this.numServID2D);
            this.grpReceptor2.Controls.Add(this.btnStop2D);
            this.grpReceptor2.Controls.Add(this.btnStart2D);
            this.grpReceptor2.Location = new System.Drawing.Point(521, 336);
            this.grpReceptor2.Name = "grpReceptor2";
            this.grpReceptor2.Size = new System.Drawing.Size(412, 256);
            this.grpReceptor2.TabIndex = 6;
            this.grpReceptor2.TabStop = false;
            this.grpReceptor2.Text = "Receptor 2";
            // 
            // lblText2D
            // 
            this.lblText2D.Location = new System.Drawing.Point(30, 203);
            this.lblText2D.Name = "lblText2D";
            this.lblText2D.Size = new System.Drawing.Size(341, 23);
            this.lblText2D.TabIndex = 3;
            this.lblText2D.Text = "(none)";
            this.lblText2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmartkey2D
            // 
            this.lblSmartkey2D.AutoSize = true;
            this.lblSmartkey2D.Location = new System.Drawing.Point(168, 52);
            this.lblSmartkey2D.Name = "lblSmartkey2D";
            this.lblSmartkey2D.Size = new System.Drawing.Size(55, 13);
            this.lblSmartkey2D.TabIndex = 3;
            this.lblSmartkey2D.Text = "SmartKey:";
            // 
            // lblSrt2D
            // 
            this.lblSrt2D.AutoSize = true;
            this.lblSrt2D.Location = new System.Drawing.Point(45, 49);
            this.lblSrt2D.Name = "lblSrt2D";
            this.lblSrt2D.Size = new System.Drawing.Size(55, 13);
            this.lblSrt2D.TabIndex = 3;
            this.lblSrt2D.Text = "Server ID:";
            // 
            // lblcopypaste2D
            // 
            this.lblcopypaste2D.AutoSize = true;
            this.lblcopypaste2D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcopypaste2D.Location = new System.Drawing.Point(190, 105);
            this.lblcopypaste2D.Name = "lblcopypaste2D";
            this.lblcopypaste2D.Size = new System.Drawing.Size(74, 13);
            this.lblcopypaste2D.TabIndex = 3;
            this.lblcopypaste2D.Text = "copiar y pegar";
            this.lblcopypaste2D.Click += new System.EventHandler(this.lblcopypaste2D_Click);
            // 
            // lblTCPlocal2D
            // 
            this.lblTCPlocal2D.AutoSize = true;
            this.lblTCPlocal2D.Location = new System.Drawing.Point(114, 105);
            this.lblTCPlocal2D.Name = "lblTCPlocal2D";
            this.lblTCPlocal2D.Size = new System.Drawing.Size(60, 13);
            this.lblTCPlocal2D.TabIndex = 3;
            this.lblTCPlocal2D.Text = "TCP Local:";
            // 
            // txtSmartkey2D
            // 
            this.txtSmartkey2D.Location = new System.Drawing.Point(229, 49);
            this.txtSmartkey2D.MaxLength = 16;
            this.txtSmartkey2D.Name = "txtSmartkey2D";
            this.txtSmartkey2D.Size = new System.Drawing.Size(142, 20);
            this.txtSmartkey2D.TabIndex = 1;
            // 
            // numServID2D
            // 
            this.numServID2D.Location = new System.Drawing.Point(106, 47);
            this.numServID2D.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numServID2D.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServID2D.Name = "numServID2D";
            this.numServID2D.Size = new System.Drawing.Size(56, 20);
            this.numServID2D.TabIndex = 0;
            this.numServID2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServID2D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop2D
            // 
            this.btnStop2D.Location = new System.Drawing.Point(171, 149);
            this.btnStop2D.Name = "btnStop2D";
            this.btnStop2D.Size = new System.Drawing.Size(75, 23);
            this.btnStop2D.TabIndex = 0;
            this.btnStop2D.TabStop = false;
            this.btnStop2D.Text = "Parar";
            this.btnStop2D.UseVisualStyleBackColor = true;
            this.btnStop2D.Click += new System.EventHandler(this.btnStop2D_Click);
            // 
            // btnStart2D
            // 
            this.btnStart2D.Location = new System.Drawing.Point(159, 149);
            this.btnStart2D.Name = "btnStart2D";
            this.btnStart2D.Size = new System.Drawing.Size(75, 23);
            this.btnStart2D.TabIndex = 0;
            this.btnStart2D.TabStop = false;
            this.btnStart2D.Text = "Emitir";
            this.btnStart2D.UseVisualStyleBackColor = true;
            this.btnStart2D.Click += new System.EventHandler(this.btnStart2D_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(939, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(465, 595);
            this.panel.TabIndex = 7;
            this.panel.Visible = false;
            // 
            // timerMDNS
            // 
            this.timerMDNS.Interval = 1000;
            this.timerMDNS.Tick += new System.EventHandler(this.timerMDNS_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 641);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.grpEmisor2);
            this.Controls.Add(this.grpReceptor2);
            this.Controls.Add(this.grpReceptor1);
            this.Controls.Add(this.grpEmisor1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI Control Codes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.grpEmisor1.ResumeLayout(false);
            this.grpEmisor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID1E)).EndInit();
            this.grpEmisor2.ResumeLayout(false);
            this.grpEmisor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID2E)).EndInit();
            this.grpReceptor1.ResumeLayout(false);
            this.grpReceptor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID1D)).EndInit();
            this.grpReceptor2.ResumeLayout(false);
            this.grpReceptor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServID2D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel statusLblMsg;
        private System.Windows.Forms.GroupBox grpEmisor1;
        private System.Windows.Forms.Label lblText1E;
        private System.Windows.Forms.Label lblSmartkey1E;
        private System.Windows.Forms.Label lblSrt1E;
        private System.Windows.Forms.Label lblSource1E;
        private System.Windows.Forms.TextBox txtSmartkey1E;
        private System.Windows.Forms.TextBox txtSource1E;
        private System.Windows.Forms.NumericUpDown numServID1E;
        private System.Windows.Forms.Button btnStop1E;
        private System.Windows.Forms.Button btnStart1E;
        private System.Windows.Forms.GroupBox grpEmisor2;
        private System.Windows.Forms.Label lblText2E;
        private System.Windows.Forms.Label lblSmartkey2E;
        private System.Windows.Forms.Label lblSrt2E;
        private System.Windows.Forms.Label lblSource2E;
        private System.Windows.Forms.TextBox txtSmartkey2E;
        private System.Windows.Forms.TextBox txtSource2E;
        private System.Windows.Forms.NumericUpDown numServID2E;
        private System.Windows.Forms.Button btnStop2E;
        private System.Windows.Forms.Button btnStart2E;
        private System.Windows.Forms.GroupBox grpReceptor1;
        private System.Windows.Forms.Label lblText1D;
        private System.Windows.Forms.Label lblSmartkey1D;
        private System.Windows.Forms.Label lblSrt1D;
        private System.Windows.Forms.Label lblTCPlocal1D;
        private System.Windows.Forms.TextBox txtSmartkey1D;
        private System.Windows.Forms.NumericUpDown numServID1D;
        private System.Windows.Forms.Button btnStop1D;
        private System.Windows.Forms.Button btnStart1D;
        private System.Windows.Forms.Label lblcopypaste1D;
        private System.Windows.Forms.GroupBox grpReceptor2;
        private System.Windows.Forms.Label lblText2D;
        private System.Windows.Forms.Label lblSmartkey2D;
        private System.Windows.Forms.Label lblSrt2D;
        private System.Windows.Forms.Label lblcopypaste2D;
        private System.Windows.Forms.Label lblTCPlocal2D;
        private System.Windows.Forms.TextBox txtSmartkey2D;
        private System.Windows.Forms.NumericUpDown numServID2D;
        private System.Windows.Forms.Button btnStop2D;
        private System.Windows.Forms.Button btnStart2D;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timerMDNS;
    }
}

