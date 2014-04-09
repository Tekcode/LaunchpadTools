namespace LaunchpadTools
{
    partial class TM4C123GXL_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TM4C123GXL_Control));
            this.launchpadToolsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lcdControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m4CortexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspberryPiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlCenterStatus = new System.Windows.Forms.StatusStrip();
            this.bluetoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchpadToolsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchpadToolsMenu
            // 
            this.launchpadToolsMenu.BackColor = System.Drawing.SystemColors.Control;
            this.launchpadToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.cOMToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.platformToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.launchpadToolsMenu.Location = new System.Drawing.Point(0, 0);
            this.launchpadToolsMenu.Name = "launchpadToolsMenu";
            this.launchpadToolsMenu.Size = new System.Drawing.Size(784, 24);
            this.launchpadToolsMenu.TabIndex = 0;
            this.launchpadToolsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cOMToolStripMenuItem
            // 
            this.cOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.cOMToolStripMenuItem.Name = "cOMToolStripMenuItem";
            this.cOMToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cOMToolStripMenuItem.Text = "COM";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialWindowToolStripMenuItem,
            this.motorControlToolStripMenuItem,
            this.lcdControlToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // serialWindowToolStripMenuItem
            // 
            this.serialWindowToolStripMenuItem.Name = "serialWindowToolStripMenuItem";
            this.serialWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.serialWindowToolStripMenuItem.Text = "Serial Window";
            this.serialWindowToolStripMenuItem.Click += new System.EventHandler(this.serialWindowToolStripMenuItem_Click);
            // 
            // motorControlToolStripMenuItem
            // 
            this.motorControlToolStripMenuItem.Name = "motorControlToolStripMenuItem";
            this.motorControlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.motorControlToolStripMenuItem.Text = "Motor Control";
            this.motorControlToolStripMenuItem.Click += new System.EventHandler(this.motorControlToolStripMenuItem_Click);
            // 
            // lcdControlToolStripMenuItem
            // 
            this.lcdControlToolStripMenuItem.Name = "lcdControlToolStripMenuItem";
            this.lcdControlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.lcdControlToolStripMenuItem.Text = "LCD Control";
            this.lcdControlToolStripMenuItem.Click += new System.EventHandler(this.lCDControlToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ethernetToolStripMenuItem,
            this.bluetoothToolStripMenuItem,
            this.wifiToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // ethernetToolStripMenuItem
            // 
            this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
            this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ethernetToolStripMenuItem.Text = "Ethernet";
            this.ethernetToolStripMenuItem.Click += new System.EventHandler(this.ethernetToolStripMenuItem_Click);
            // 
            // wifiToolStripMenuItem
            // 
            this.wifiToolStripMenuItem.Name = "wifiToolStripMenuItem";
            this.wifiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wifiToolStripMenuItem.Text = "Wifi";
            this.wifiToolStripMenuItem.Click += new System.EventHandler(this.wifiToolStripMenuItem_Click);
            // 
            // platformToolStripMenuItem
            // 
            this.platformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m4CortexToolStripMenuItem,
            this.raspberryPiToolStripMenuItem,
            this.arduinoToolStripMenuItem});
            this.platformToolStripMenuItem.Name = "platformToolStripMenuItem";
            this.platformToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.platformToolStripMenuItem.Text = "Platform";
            // 
            // m4CortexToolStripMenuItem
            // 
            this.m4CortexToolStripMenuItem.Name = "m4CortexToolStripMenuItem";
            this.m4CortexToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.m4CortexToolStripMenuItem.Text = "M4 Cortex";
            this.m4CortexToolStripMenuItem.Click += new System.EventHandler(this.m4CortexToolStripMenuItem_Click);
            // 
            // raspberryPiToolStripMenuItem
            // 
            this.raspberryPiToolStripMenuItem.Name = "raspberryPiToolStripMenuItem";
            this.raspberryPiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.raspberryPiToolStripMenuItem.Text = "Raspberry Pi";
            this.raspberryPiToolStripMenuItem.Click += new System.EventHandler(this.raspberryPiToolStripMenuItem_Click);
            // 
            // arduinoToolStripMenuItem
            // 
            this.arduinoToolStripMenuItem.Name = "arduinoToolStripMenuItem";
            this.arduinoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.arduinoToolStripMenuItem.Text = "Arduino";
            this.arduinoToolStripMenuItem.Click += new System.EventHandler(this.arduinoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadCodeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // downloadCodeToolStripMenuItem
            // 
            this.downloadCodeToolStripMenuItem.Name = "downloadCodeToolStripMenuItem";
            this.downloadCodeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.downloadCodeToolStripMenuItem.Text = "Download Code";
            this.downloadCodeToolStripMenuItem.Click += new System.EventHandler(this.downloadCodeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // controlCenterStatus
            // 
            this.controlCenterStatus.Location = new System.Drawing.Point(0, 540);
            this.controlCenterStatus.Name = "controlCenterStatus";
            this.controlCenterStatus.Size = new System.Drawing.Size(784, 22);
            this.controlCenterStatus.TabIndex = 1;
            // 
            // bluetoothToolStripMenuItem
            // 
            this.bluetoothToolStripMenuItem.Name = "bluetoothToolStripMenuItem";
            this.bluetoothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bluetoothToolStripMenuItem.Text = "Bluetooth";
            this.bluetoothToolStripMenuItem.Click += new System.EventHandler(this.bluetoothToolStripMenuItem_Click);
            // 
            // TM4C123GXL_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.controlCenterStatus);
            this.Controls.Add(this.launchpadToolsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.launchpadToolsMenu;
            this.MaximizeBox = false;
            this.Name = "TM4C123GXL_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launchpad Tools";
            this.launchpadToolsMenu.ResumeLayout(false);
            this.launchpadToolsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip launchpadToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip controlCenterStatus;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lcdControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m4CortexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspberryPiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluetoothToolStripMenuItem;
    }
}

