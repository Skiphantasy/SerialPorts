/*
 * EXERCISE............: Exercise 10.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP.....: 2º Interface Development 
 * PROJECT.............: Forms III. Serial Port and DLL
 * DATE................: 30 Jan 2019
 */

namespace Exercise10
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.lblPorts = new System.Windows.Forms.Label();
            this.cmbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblBitCar = new System.Windows.Forms.Label();
            this.lblBitStop = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.txtBitCar = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cmbPar = new System.Windows.Forms.ComboBox();
            this.cmbStop = new System.Windows.Forms.ComboBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.BackColor = System.Drawing.Color.Transparent;
            this.lblPorts.Location = new System.Drawing.Point(11, 39);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(98, 13);
            this.lblPorts.TabIndex = 0;
            this.lblPorts.Text = "Puertos disponibles";
            // 
            // cmbAvailablePorts
            // 
            this.cmbAvailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailablePorts.FormattingEnabled = true;
            this.cmbAvailablePorts.Location = new System.Drawing.Point(132, 36);
            this.cmbAvailablePorts.Name = "cmbAvailablePorts";
            this.cmbAvailablePorts.Size = new System.Drawing.Size(99, 21);
            this.cmbAvailablePorts.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmbAvailablePorts, "Puertos disponibles");
            this.cmbAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.cmbAvailablePorts_SelectedIndexChanged);
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocity.Location = new System.Drawing.Point(11, 66);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(54, 13);
            this.lblVelocity.TabIndex = 2;
            this.lblVelocity.Text = "Velocidad";
            // 
            // lblBitCar
            // 
            this.lblBitCar.AutoSize = true;
            this.lblBitCar.BackColor = System.Drawing.Color.Transparent;
            this.lblBitCar.Location = new System.Drawing.Point(11, 92);
            this.lblBitCar.Name = "lblBitCar";
            this.lblBitCar.Size = new System.Drawing.Size(79, 13);
            this.lblBitCar.TabIndex = 3;
            this.lblBitCar.Text = "Nº Bit/Carácter";
            // 
            // lblBitStop
            // 
            this.lblBitStop.AutoSize = true;
            this.lblBitStop.BackColor = System.Drawing.Color.Transparent;
            this.lblBitStop.Location = new System.Drawing.Point(11, 118);
            this.lblBitStop.Name = "lblBitStop";
            this.lblBitStop.Size = new System.Drawing.Size(59, 13);
            this.lblBitStop.TabIndex = 4;
            this.lblBitStop.Text = "Nº Bit Stop";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.BackColor = System.Drawing.Color.Transparent;
            this.lblParity.Location = new System.Drawing.Point(11, 145);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(43, 13);
            this.lblParity.TabIndex = 5;
            this.lblParity.Text = "Paridad";
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(132, 63);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(99, 20);
            this.txtVelocity.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtVelocity, "Velocidad del puerto");
            this.txtVelocity.TextChanged += new System.EventHandler(this.txtVelocity_TextChanged);
            // 
            // txtBitCar
            // 
            this.txtBitCar.Location = new System.Drawing.Point(132, 89);
            this.txtBitCar.Name = "txtBitCar";
            this.txtBitCar.Size = new System.Drawing.Size(99, 20);
            this.txtBitCar.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtBitCar, "Nº Bit/Carácter");
            this.txtBitCar.TextChanged += new System.EventHandler(this.txtBitCar_TextChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(132, 169);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(99, 23);
            this.btnContinue.TabIndex = 10;
            this.btnContinue.Text = "Abrir Puerto";
            this.toolTip.SetToolTip(this.btnContinue, "Abrir puerto seleccionado");
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // cmbPar
            // 
            this.cmbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPar.FormattingEnabled = true;
            this.cmbPar.Location = new System.Drawing.Point(132, 142);
            this.cmbPar.Name = "cmbPar";
            this.cmbPar.Size = new System.Drawing.Size(99, 21);
            this.cmbPar.TabIndex = 11;
            this.toolTip.SetToolTip(this.cmbPar, "Paridad");
            // 
            // cmbStop
            // 
            this.cmbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStop.FormattingEnabled = true;
            this.cmbStop.Location = new System.Drawing.Point(132, 115);
            this.cmbStop.Name = "cmbStop";
            this.cmbStop.Size = new System.Drawing.Size(99, 21);
            this.cmbStop.TabIndex = 12;
            this.toolTip.SetToolTip(this.cmbStop, "Nº Bit Stop");
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(14, 169);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(95, 23);
            this.btnClosePort.TabIndex = 13;
            this.btnClosePort.Text = "Cerrar Puerto";
            this.toolTip.SetToolTip(this.btnClosePort, "Cerrar Puerto seleccionado");
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(457, 24);
            this.mnuMenu.TabIndex = 14;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarFicheroToolStripMenuItem,
            this.recibirFicheroToolStripMenuItem,
            this.chatTextoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // enviarFicheroToolStripMenuItem
            // 
            this.enviarFicheroToolStripMenuItem.Name = "enviarFicheroToolStripMenuItem";
            this.enviarFicheroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enviarFicheroToolStripMenuItem.Text = "Enviar Fichero";
            this.enviarFicheroToolStripMenuItem.Click += new System.EventHandler(this.enviarFicheroToolStripMenuItem_Click);
            // 
            // recibirFicheroToolStripMenuItem
            // 
            this.recibirFicheroToolStripMenuItem.Name = "recibirFicheroToolStripMenuItem";
            this.recibirFicheroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recibirFicheroToolStripMenuItem.Text = "Recibir Fichero";
            this.recibirFicheroToolStripMenuItem.Click += new System.EventHandler(this.recibirFicheroToolStripMenuItem_Click);
            // 
            // chatTextoToolStripMenuItem
            // 
            this.chatTextoToolStripMenuItem.Name = "chatTextoToolStripMenuItem";
            this.chatTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chatTextoToolStripMenuItem.Text = "Chat Texto";
            this.chatTextoToolStripMenuItem.Click += new System.EventHandler(this.chatTextoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(256, 65);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(184, 100);
            this.txtBox.TabIndex = 15;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(256, 171);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(100, 20);
            this.txtSend.TabIndex = 16;
            this.toolTip.SetToolTip(this.txtSend, "Escribe algo...");
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(362, 171);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 20);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Enviar";
            this.toolTip.SetToolTip(this.btnSend, "Enviar texto");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(253, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(106, 17);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Modo Activo: ";
            this.toolTip.SetToolTip(this.lblHeader, "Modo actual del formulario");
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Exercise10";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 206);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.cmbStop);
            this.Controls.Add(this.cmbPar);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtBitCar);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.lblParity);
            this.Controls.Add(this.lblBitStop);
            this.Controls.Add(this.lblBitCar);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.cmbAvailablePorts);
            this.Controls.Add(this.lblPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Text = "Comunicación";
            this.Shown += new System.EventHandler(this.frmConfig_Shown);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cmbAvailablePorts;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblBitCar;
        private System.Windows.Forms.Label lblBitStop;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.TextBox txtBitCar;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox cmbPar;
        private System.Windows.Forms.ComboBox cmbStop;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarFicheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibirFicheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolStripMenuItem chatTextoToolStripMenuItem;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

