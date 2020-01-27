using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;


namespace PanelBrowser
{
    public partial class settings : Form 
    {

        // CONSTRUCTOR. INITIALIZING COMPONENTS
        public settings() {
            InitializeComponent();
        }

        // ON LOAD
        private void settings_Load(object sender, EventArgs e) {
            doGetStates();
            label9.Text = "ScreenDrone" + "\r\n\r\n" + "Version: " + Panel.getVersionData(5); // About -> version TAB
            Text = "ScreenDrone | Settings"; // window title
        }


        // ##################################
        // METHODS AND FUNCTIONS
        // ##################################

        // LOAD CURRENT CONFIG SETTINGS FROM REGISTRY
        public void doGetStates()
        {

            // SCROLLBARS
            if (Panel.regFetchValue("Scrollbars") == "False" || Panel.regFetchValue("Scrollbars") == "false")
            {
                settingButtonScrollbarsOff.Enabled = false;
                settingButtonScrollbarsOn.Enabled = true;
            }
            else if (Panel.regFetchValue("Scrollbars") == "True" || Panel.regFetchValue("Scrollbars") == "true")
            {
                settingButtonScrollbarsOn.Enabled = false;
                settingButtonScrollbarsOff.Enabled = true;
            }

            // AUTORUN ON/OFF
            if (Panel.regFetchValue("Autorun") == "False" || Panel.regFetchValue("Scrollbars") == "false")
            {
                settingButtonAutorunOn.Enabled = true;
                settingButtonAutorunOff.Enabled = false;
            }
            else if (Panel.regFetchValue("Autorun") == "True" || Panel.regFetchValue("Scrollbars") == "true")
            {
                settingButtonAutorunOn.Enabled = false;
                settingButtonAutorunOff.Enabled = true;
            }

            // AUTORUN RATE
            if (Panel.regFetchValue("AutorunRate") != null)
                SettingsAutorunRateTime.Value = Convert.ToInt32(Panel.regFetchValue("AutorunRate"));

            // HOME URL state
            if (Panel.regFetchValue("HomeURLstate") != null)
                SettingsHomeURLstate.Checked = Convert.ToBoolean(Panel.regFetchValue("HomeURLstate"));

            // HOME URL
            if (Panel.regFetchValue("HomeURL") != null || SettingsHomeURLstate.Checked != false)
                SettingsHomeURL.Text = Panel.regFetchValue("HomeURL");

            // URL LIST
            if (Panel.regFetchValue("URLfileLocation") != null)
                SettingsURLfileLocation.Text = Panel.regFetchValue("URLfileLocation");
        }

        // UPDATE REGISTRY (1) HANDLER
        private void runRegUpdateValue(string item, string msg)
        {

            if (regUpdateValue(item, msg) == true)
            {

                string iappend = Panel.regFetchValue(item);
                int statusType = 1;
                if (iappend != null)
                    {
                    
                        if (iappend == "True")
                            {
                                iappend = (item + " is now ON");
                            }
                        else if (iappend == "False")
                            {
                                iappend = (item + " is now OFF");
                            }
                        else
                            {
                                iappend = (item + " has been set to: " + iappend);
                            }

                        changeStatusBar(iappend, statusType);
                    }
                else
                    {
                        // iappend = (item + " returns an ERROR. No Value!");
                        // statusType = 0;
                    }


                doGetStates();


            }
            else if (regUpdateValue(item, msg) == false)
            {
                changeStatusBar(item, 0);
            }
        }

        // UPDATE REGISTRY (2) VALUE
        public bool regUpdateValue(string iName, string iValue) {
            try
            {
                @Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\HostDrone\\PanelBrowser", iName, iValue);
                return true;
            }
            catch (Exception MyError)
            {
                changeStatusBar(MyError.Message, 1);
                return false;
            }
        }

        // UPDATE CONFIG STATUS BAR
        private void changeStatusBar(string item, int type)
        {
            string printNow = (
                                DateTime.Now.Year.ToString() + "-" +
                                DateTime.Now.Month.ToString() + "-" +
                                DateTime.Now.Day.ToString() + " " +
                                DateTime.Now.Hour.ToString() + ":" +
                                DateTime.Now.Minute.ToString() + ":" +
                                DateTime.Now.Second.ToString() + "\r\n"
                              );

            if (type == 0)// ERROR
            {
                statusStrip1.BackColor = System.Drawing.Color.LightCoral;
                settingsStatusBarLabel.Text = (printNow + item);
            }

            if (type == 1) // SUCCESS
            {
                statusStrip1.BackColor = System.Drawing.SystemColors.Control;
                settingsStatusBarLabel.Text = (printNow + item);
            }

            if (type == 2) // HELP
            {
                statusStrip1.BackColor = System.Drawing.Color.SkyBlue;
                settingsStatusBarLabel.Text = (item);
            }
        }

        // ##################################
        // INFO/HELP TOOL BUTTONS
        // ##################################

        private void button8_Click(object sender, EventArgs e) {
            changeStatusBar("Load-on-start URL. Opens when you start the program." + "\r\n" + "Change the URL or remove the check-mark to skip", 2);
        }

        private void button13_Click(object sender, EventArgs e) {
            changeStatusBar("Text file containing URL toggle list. Click edit to modify" + "\r\n" + "the file using you default text editor", 2);
        }

        private void button10_Click(object sender, EventArgs e) {
            changeStatusBar("Enable or disable the Auto toggle feature." + "\r\n" + "When disabled, the browser will not update.", 2);
        }

        private void button11_Click_1(object sender, EventArgs e) {
            changeStatusBar("Sets the rate of update time between URLs" + "\r\n" + "Value is in seconds. Max value is 600", 2);
        }

        private void button7_Click_1(object sender, EventArgs e) {
            changeStatusBar("Enable or disable scrollbars to appear", 2);
        }


        // ##################################
        // HELP/ABOUT PANE
        // ##################################

        // HELP - UPDATES BUTTON
        private void button6_Click_1(object sender, EventArgs e){
            string targetURL = @"http://hostdrone.queryhouse.com/hostdrone/download/";
            Process.Start(targetURL);
        }

        // HELP - HOMEPAGE BUTTON
        private void button7_Click(object sender, EventArgs e){
            string targetURL = @"http://hostdrone.com/";
            Process.Start(targetURL);
        }


        // ##################################
        // CONFIG BUTTONS
        // ##################################

        // HOME URL LOCATION
        private void button2_Click_1(object sender, EventArgs e) {
            runRegUpdateValue("HomeURL", SettingsHomeURL.Text);
        }

        // HOME URL ON/OFF
        private void SettingsHomeURLstate_CheckedChanged_1(object sender, EventArgs e) {
            runRegUpdateValue("HomeURLstate", SettingsHomeURLstate.Checked.ToString());
        }

        // SCROLL BARS OFF
        private void settingButtonScrollbar_Click_1(object sender, EventArgs e) {
            runRegUpdateValue("Scrollbars", "False");
        }

        // SCROLL BARS ON
        private void button9_Click(object sender, EventArgs e) {
            runRegUpdateValue("Scrollbars", "True");
        }

        // AUTORUN ON
        private void settingButtonAutorun_Click_1(object sender, EventArgs e)
        {
            runRegUpdateValue("Autorun", "False");
        }

        // AUTORUN OFF
        private void button11_Click(object sender, EventArgs e) {
            runRegUpdateValue("Autorun", "True");
        }

        // AUTORUN RATE
        private void button1_Click_1(object sender, EventArgs e)
        {
            runRegUpdateValue("AutorunRate", SettingsAutorunRateTime.Value.ToString());
        }

        // URL-LIST. FILE LOCATION
        private void button3_Click(object sender, EventArgs e)
        {
            runRegUpdateValue("URLfileLocation", SettingsURLfileLocation.Text);
        }

        // URL-LIST. EDIT BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Panel.regFetchValue("URLfileLocation"));
            }
            catch (Exception MyError)
            {
                changeStatusBar(MyError.Message, 1);
            }
        }

        // URL-LIST. BROWSE FOR FILE
        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "PanelBrowser | Locate URL text file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Text Files (*.txt)|*.txt";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                SettingsURLfileLocation.Text = fdlg.FileName;
            }
        }


    }
}
