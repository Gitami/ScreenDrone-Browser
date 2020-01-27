namespace PanelBrowser
{
    partial class Splash
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
            this.splashloadbar = new System.Windows.Forms.ProgressBar();
            this.Splashloadbartimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // splashloadbar
            // 
            this.splashloadbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splashloadbar.ForeColor = System.Drawing.Color.GreenYellow;
            this.splashloadbar.Location = new System.Drawing.Point(74, 232);
            this.splashloadbar.Name = "splashloadbar";
            this.splashloadbar.Size = new System.Drawing.Size(301, 17);
            this.splashloadbar.TabIndex = 0;
            this.splashloadbar.UseWaitCursor = true;
            // 
            // Splashloadbartimer
            // 
            this.Splashloadbartimer.Enabled = true;
            this.Splashloadbartimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ScreenDrone.Properties.Resources.screendrone_splash3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(471, 329);
            this.Controls.Add(this.splashloadbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar splashloadbar;
        private System.Windows.Forms.Timer Splashloadbartimer;
    }
}