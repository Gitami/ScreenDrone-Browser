namespace PanelBrowser
{
    partial class Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.contentmenu_browser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screendumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webpageInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyBrowserIECacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.context_pagesettings = new System.Windows.Forms.ToolStripMenuItem();
            this.internetOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainWindowNotificationsLabel = new System.Windows.Forms.Label();
            this.NotifyEnduser_timer = new System.Windows.Forms.Timer(this.components);
            this.contentmenu_browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentmenu_browser
            // 
            this.contentmenu_browser.BackColor = System.Drawing.Color.LightSlateGray;
            this.contentmenu_browser.DropShadowEnabled = false;
            this.contentmenu_browser.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.contentmenu_browser.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contentmenu_browser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelBrowserToolStripMenuItem,
            this.applySettingsToolStripMenuItem,
            this.screendumpToolStripMenuItem,
            this.savePageAsToolStripMenuItem,
            this.emptyBrowserIECacheToolStripMenuItem,
            this.toolStripSeparator2,
            this.context_pagesettings,
            this.internetOptionsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitProgramToolStripMenuItem});
            this.contentmenu_browser.Name = "contentmenu_browser";
            this.contentmenu_browser.Size = new System.Drawing.Size(217, 289);
            // 
            // panelBrowserToolStripMenuItem
            // 
            this.panelBrowserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.panelBrowserToolStripMenuItem.AutoSize = false;
            this.panelBrowserToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelBrowserToolStripMenuItem.BackgroundImage = global::ScreenDrone.Properties.Resources.dropdownmenubanner;
            this.panelBrowserToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBrowserToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panelBrowserToolStripMenuItem.Font = new System.Drawing.Font("Kalinga", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBrowserToolStripMenuItem.ForeColor = System.Drawing.Color.MintCream;
            this.panelBrowserToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.panelBrowserToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.panelBrowserToolStripMenuItem.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.panelBrowserToolStripMenuItem.Name = "panelBrowserToolStripMenuItem";
            this.panelBrowserToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.panelBrowserToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelBrowserToolStripMenuItem.Size = new System.Drawing.Size(200, 55);
            this.panelBrowserToolStripMenuItem.Text = "Panel Browsing";
            // 
            // applySettingsToolStripMenuItem
            // 
            this.applySettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applySettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applySettingsToolStripMenuItem.Image")));
            this.applySettingsToolStripMenuItem.Name = "applySettingsToolStripMenuItem";
            this.applySettingsToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.applySettingsToolStripMenuItem.Text = "Recycle application";
            this.applySettingsToolStripMenuItem.Click += new System.EventHandler(this.applySettingsToolStripMenuItem_Click);
            // 
            // screendumpToolStripMenuItem
            // 
            this.screendumpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.screendumpToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_screenshot;
            this.screendumpToolStripMenuItem.Name = "screendumpToolStripMenuItem";
            this.screendumpToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.screendumpToolStripMenuItem.Text = "Screendump";
            this.screendumpToolStripMenuItem.Click += new System.EventHandler(this.screendumpToolStripMenuItem_Click);
            // 
            // savePageAsToolStripMenuItem
            // 
            this.savePageAsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savePageAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPageToolStripMenuItem,
            this.savePageAsToolStripMenuItem1,
            this.propertiesToolStripMenuItem,
            this.webpageInformationToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printPageToolStripMenuItem});
            this.savePageAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.savePageAsToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_pageoption;
            this.savePageAsToolStripMenuItem.Name = "savePageAsToolStripMenuItem";
            this.savePageAsToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.savePageAsToolStripMenuItem.Text = "Page options";
            // 
            // refreshPageToolStripMenuItem
            // 
            this.refreshPageToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.refreshPageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshPageToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_refreshpage;
            this.refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            this.refreshPageToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.refreshPageToolStripMenuItem.Text = "Refresh page";
            this.refreshPageToolStripMenuItem.Click += new System.EventHandler(this.refreshPageToolStripMenuItem_Click);
            // 
            // savePageAsToolStripMenuItem1
            // 
            this.savePageAsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSlateGray;
            this.savePageAsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.savePageAsToolStripMenuItem1.Image = global::ScreenDrone.Properties.Resources.icon_savepageas1;
            this.savePageAsToolStripMenuItem1.Name = "savePageAsToolStripMenuItem1";
            this.savePageAsToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.savePageAsToolStripMenuItem1.Text = "Save page as...";
            this.savePageAsToolStripMenuItem1.Click += new System.EventHandler(this.savePageAsToolStripMenuItem1_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.propertiesToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_properties;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.propertiesToolStripMenuItem.Text = "View properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // webpageInformationToolStripMenuItem
            // 
            this.webpageInformationToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.webpageInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.webpageInformationToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_pagedetails;
            this.webpageInformationToolStripMenuItem.Name = "webpageInformationToolStripMenuItem";
            this.webpageInformationToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.webpageInformationToolStripMenuItem.Text = "View details";
            this.webpageInformationToolStripMenuItem.Click += new System.EventHandler(this.webpageInformationToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.printPreviewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printPreviewToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_printpreview;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.printPageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printPageToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_print;
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.printPageToolStripMenuItem.Text = "Print page";
            this.printPageToolStripMenuItem.Click += new System.EventHandler(this.printPageToolStripMenuItem_Click);
            // 
            // emptyBrowserIECacheToolStripMenuItem
            // 
            this.emptyBrowserIECacheToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.emptyBrowserIECacheToolStripMenuItem.Image = global::ScreenDrone.Properties.Resources.icon_cleariecache;
            this.emptyBrowserIECacheToolStripMenuItem.Name = "emptyBrowserIECacheToolStripMenuItem";
            this.emptyBrowserIECacheToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.emptyBrowserIECacheToolStripMenuItem.Text = "Empty browser (IE) cache";
            this.emptyBrowserIECacheToolStripMenuItem.Click += new System.EventHandler(this.emptyBrowserIECacheToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // context_pagesettings
            // 
            this.context_pagesettings.ForeColor = System.Drawing.Color.White;
            this.context_pagesettings.Image = ((System.Drawing.Image)(resources.GetObject("context_pagesettings.Image")));
            this.context_pagesettings.Name = "context_pagesettings";
            this.context_pagesettings.Size = new System.Drawing.Size(216, 28);
            this.context_pagesettings.Text = "Settings";
            this.context_pagesettings.Click += new System.EventHandler(this.context_pagesettings_Click);
            // 
            // internetOptionsToolStripMenuItem1
            // 
            this.internetOptionsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.internetOptionsToolStripMenuItem1.Image = global::ScreenDrone.Properties.Resources.icon_internetoptions;
            this.internetOptionsToolStripMenuItem1.Name = "internetOptionsToolStripMenuItem1";
            this.internetOptionsToolStripMenuItem1.Size = new System.Drawing.Size(216, 28);
            this.internetOptionsToolStripMenuItem1.Text = "IE options";
            this.internetOptionsToolStripMenuItem1.Click += new System.EventHandler(this.internetOptionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.exitProgramToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.exitProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitProgramToolStripMenuItem.Image")));
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.exitProgramToolStripMenuItem.Text = "Stop and exit";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contentmenu_browser;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(450, 376);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindowNotificationsLabel
            // 
            this.MainWindowNotificationsLabel.AutoSize = true;
            this.MainWindowNotificationsLabel.BackColor = System.Drawing.Color.SlateGray;
            this.MainWindowNotificationsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainWindowNotificationsLabel.Enabled = false;
            this.MainWindowNotificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowNotificationsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.MainWindowNotificationsLabel.Location = new System.Drawing.Point(50, 50);
            this.MainWindowNotificationsLabel.Name = "MainWindowNotificationsLabel";
            this.MainWindowNotificationsLabel.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.MainWindowNotificationsLabel.Size = new System.Drawing.Size(30, 36);
            this.MainWindowNotificationsLabel.TabIndex = 0;
            this.MainWindowNotificationsLabel.Visible = false;
            // 
            // NotifyEnduser_timer
            // 
            this.NotifyEnduser_timer.Interval = 500;
            this.NotifyEnduser_timer.Tick += new System.EventHandler(this.NotifyEnduser_timer_Tick);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(450, 376);
            this.ControlBox = false;
            this.Controls.Add(this.MainWindowNotificationsLabel);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contentmenu_browser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contentmenu_browser;
        private System.Windows.Forms.ToolStripMenuItem context_pagesettings;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem applySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screendumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyBrowserIECacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetOptionsToolStripMenuItem1;
        public System.Windows.Forms.Label MainWindowNotificationsLabel;
        private System.Windows.Forms.Timer NotifyEnduser_timer;
        private System.Windows.Forms.ToolStripMenuItem webpageInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

