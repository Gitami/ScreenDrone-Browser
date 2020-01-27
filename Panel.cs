using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;



namespace PanelBrowser
{
    public partial class Panel : Form
    {

        // PACKAGE Version and Build details
        public static string getVersionData(short i){
            double versionNumber = 0.85;
            string versionBuildDate = "2009-11-28";
            string versionReleaseType = "RC"; // From BETA to RC @ 2009-11-28

            if(i == 1) // version number only
            {
                return (versionNumber.ToString());
            }
            else if(i == 2) // Build date only
            {
                return (versionBuildDate);
            }
            else if (i == 3) // Type only (BETA, ALFA)
            {
                return (versionReleaseType);
            }
            else if (i == 4) // All. One lined string
            {
                return (versionNumber.ToString() + " " + versionReleaseType + ". Build " + versionBuildDate);
            }
            else if (i == 5) // All. String w. Linebreak
            {
                return (versionNumber.ToString() + " " + versionReleaseType + "." + "\r\n" + "Build " + versionBuildDate);
            }
            else // if shit happens
            {
                return null;
            }
        }

        public Panel()
        {
            InitializeComponent();
            Text = "ScreenDrone v. " + Panel.getVersionData(4); // window title
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            fetchSettings();

            // Run splashscreen
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(2000);
            th.Abort();
            Thread.Sleep(500);
        }

        public void NotifyEnduser(string msgContent, int msgDuration, bool msgUrgent)
        {
            // Send message to the label and bring it out of hiding
            MainWindowNotificationsLabel.Text = MainWindowNotificationsLabel.Text + "\r\n" + msgContent;
            MainWindowNotificationsLabel.Visible = true;
            MainWindowNotificationsLabel.Enabled = true;

            if (msgUrgent == true)  // if it is urgent
            {

                MainWindowNotificationsLabel.BackColor = System.Drawing.Color.Red;
                MainWindowNotificationsLabel.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                MainWindowNotificationsLabel.BackColor = System.Drawing.Color.SlateGray;
                MainWindowNotificationsLabel.ForeColor = System.Drawing.Color.Yellow;
            }

            // Start timer
            if (msgDuration < 1000)
                NotifyEnduser_timer.Interval = (msgDuration * 1000);
            else
                NotifyEnduser("ERROR. An error message was logged with a value of over 1000 seconds", 4, false);

            NotifyEnduser_timer.Enabled = true;

        }


        private void NotifyEnduser_timer_Tick(object sender, EventArgs e)
        {
            // And reset...
            MainWindowNotificationsLabel.Text = "";
            MainWindowNotificationsLabel.Visible = false;
            MainWindowNotificationsLabel.Enabled = false;

            // stop timer (itself).
            NotifyEnduser_timer.Enabled = false;
        }


        // Splashcreen Windows
        public void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        // Settings Window
        public void DoSettings()
        {
            settings se = new settings();
            se.ShowDialog();
        }



        // #############################################
        // Getting settings from registry on load
        // #############################################

        public static string[] ArrayOfURLs;


        public void fetchSettings()
        {

            // SCROLLBARS
            if (@regFetchValue("Scrollbars") == null)
            {
                NotifyEnduser("Detected missing data item (Scrollbars) in the Windows Registry. Attempting to correct...", 10, true);
                try
                {
                    settings ss = new settings();
                    ss.regUpdateValue("Scrollbars", "False");
                    webBrowser1.ScrollBarsEnabled = Convert.ToBoolean(@regFetchValue("Scrollbars"));
                    NotifyEnduser("Success! Scrollbars Fixed!", 5, false);
                }
                catch (Exception ex)
                {
                    NotifyEnduser(("Failed! Unable to correct: Scrollbars! ERROR REPORTED: " + ex.Message), 10, true);
                }
            }
            else
            {
                webBrowser1.ScrollBarsEnabled = Convert.ToBoolean(@regFetchValue("Scrollbars"));
            }

            // AUTORUN TOGGLE
            if (@regFetchValue("Autorun") == null)
            {
                NotifyEnduser("Detected missing data item (Autorun) in the Windows Registry. Attempting to correct...", 10, true);
                try
                {
                    settings ss = new settings();
                    ss.regUpdateValue("Autorun", "False");
                    timer1.Enabled = Convert.ToBoolean(@regFetchValue("Autorun"));
                    NotifyEnduser("Success! Autorun Fixed!", 5, false);
                }
                catch (Exception ex)
                {
                    NotifyEnduser(("Failed! Unable to correct: Autorun! ERROR REPORTED: " + ex.Message), 10, true);
                }
            }
            else
            {
                timer1.Enabled = Convert.ToBoolean(@regFetchValue("Autorun"));
            }

            // AUTORUN RATE
            if (@regFetchValue("AutorunRate") == null)
            {
                NotifyEnduser("Detected missing data item (AutorunRate) in the Windows Registry. Attempting to correct...", 10, true);
                try
                {
                    settings ss = new settings();
                    ss.regUpdateValue("AutorunRate", "11");
                    timer1.Interval = (1000 * Convert.ToInt32(@regFetchValue("AutorunRate")));
                    NotifyEnduser("Success! AutorunRate Fixed!", 5, false);
                }
                catch (Exception ex)
                {
                    NotifyEnduser(("Failed! Unable to correct: AutorunRate! ERROR REPORTED: " + ex.Message), 10, true);
                }
            }
            else
            {
                timer1.Interval = (1000 * Convert.ToInt32(@regFetchValue("AutorunRate")));
            }


            string filepath ="";
            if (@regFetchValue("URLfileLocation") == null)
            {
                NotifyEnduser("Detected missing data item (URLfileLocation) in the Windows Registry. Attempting to correct...", 10, true);
                try{
                    settings ss = new settings();
                    ss.regUpdateValue("URLfileLocation", (@Path.GetFullPath(System.Environment.CurrentDirectory.ToString()) + "\\urls.txt"));
                    filepath = @regFetchValue("URLfileLocation");
                    NotifyEnduser("Success! URLfileLocation Fixed!", 5, false);

                }
                catch (Exception ex)
                {
                    NotifyEnduser(("Failed! Unable to correct: URLfileLocation! ERROR REPORTED: " + ex.Message), 10, true);
                }
            }
            else
            {
                filepath = @regFetchValue("URLfileLocation");
            }


            // READING FROM URL FILE
            if (File.Exists(filepath))
            {
                try
                {
                    ArrayOfURLs = File.ReadAllLines(filepath);
                }
                catch (Exception ex2)
                {
                    NotifyEnduser(("File:" + filepath + " exist but cannot be access (read). ERROR REPORTED: " + ex2.Message), 4, true);
                }
            }
            else
            {
                NotifyEnduser("URL file does not exist. Location:\r\n" + filepath + "is incorrect", 10, true);
                timer1.Enabled = false;
            }




            // HOME URL state
            if (@regFetchValue("HomeURLstate") == null)
            {
                NotifyEnduser("Detected missing data item (HomeURLstate) in the Windows Registry. Attempting to correct...", 10, true);
                try
                {
                    settings ss = new settings();
                    ss.regUpdateValue("HomeURLstate", "True");
                    timer1.Enabled = Convert.ToBoolean(@regFetchValue("HomeURLstate"));
                    NotifyEnduser("Success! HomeURLstate Fixed!", 5, false);
                }
                catch (Exception ex)
                {
                    NotifyEnduser(("Failed! Unable to correct: HomeURLstate! ERROR REPORTED: " + ex.Message), 10, true);
                }
            }

            // HOME URL ADDRESS
            bool myURLstate = Convert.ToBoolean(@regFetchValue("HomeURLstate"));
            if (myURLstate == true)
            {
                if (@regFetchValue("HomeURL") == null)
                {
                    NotifyEnduser("Detected missing data item (HomeURL) in the Windows Registry. Attempting to correct...", 10, true);
                    try
                    {
                        settings ss = new settings();
                        ss.regUpdateValue("HomeURL", "http://hostdrone.com");
                        webBrowser1.Url = new System.Uri((@regFetchValue("HomeURL")), System.UriKind.Absolute);
                        NotifyEnduser("Success! HomeURL Fixed!", 5, false);
                    }
                    catch (Exception ex)
                    {
                        NotifyEnduser(("Failed! Unable to correct: HomeURL! ERROR REPORTED: " + ex.Message), 10, true);
                    }
                }
                else
                {
                    webBrowser1.Url = new System.Uri((@regFetchValue("HomeURL")), System.UriKind.Absolute);
                }
            }
            else
            {
                NotifyEnduser("NOTE: URL autoRun is currently disabled", 10, false);
            }

        }


        // ##########################################
        // Get values from registry
        // ##########################################

        public static string regFetchValue(string Name)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\HostDrone\\PanelBrowser");
            if (key != null)
            {
                try
                {
                    string myKey = key.GetValue(Name).ToString();
                    return myKey;
                }
                catch(Exception)
                {
                    return null;
                }
            }
            return null;
        }


        // timer
        public int arrTimerCounter = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (arrTimerCounter < (ArrayOfURLs.Length))
            {
                webBrowser1.Url = new System.Uri(ArrayOfURLs[arrTimerCounter], System.UriKind.Absolute);
                arrTimerCounter++;
            }
            else 
            {
                arrTimerCounter = 0;
                webBrowser1.Url = new System.Uri(ArrayOfURLs[arrTimerCounter], System.UriKind.Absolute);
            }
        }

        // Start settings menu
        public void context_pagesettings_Click(object sender, EventArgs e)
        {
            DoSettings();
        }



        // Method for resizing an array
        public static System.Array ResizeArray(System.Array oldArray, int newSize)
        {
            int oldSize = oldArray.Length;
            System.Type elementType = oldArray.GetType().GetElementType();
            System.Array newArray = System.Array.CreateInstance(elementType, newSize);
            int preserveLength = System.Math.Min(oldSize, newSize);
            if (preserveLength > 0)
                System.Array.Copy(oldArray, newArray, preserveLength);
            return newArray;
        }

        // NotifyEnduser(string , int                 , bool     )
        // NotifyEnduser(message, duration(in seconds), critital?)
        // ....
        // ClassA SomeNewName = new ClassA();
        // SomeNewName.NotifyEnduser("", 4, false);


        private void applySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchSettings();
        }

        private void screendumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a unique filename to avoid conflicts/overwritten files
            String myUniqueFileName = (Convert.ToString((DateTime.Now.ToShortDateString())) + "_" + Convert.ToString((DateTime.Now.ToFileTimeUtc())));
 
            Image bmpScreenshot = new Bitmap(Screen.AllScreens[0].WorkingArea.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

            // Specify the directory to dump the screenies into. The folder where the program runs from
            // string path = @Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\screenshots";
            string path = @Path.GetFullPath(System.Environment.CurrentDirectory.ToString()) + "\\screenshots";

            // Determine whether the directory exists.
            if (Directory.Exists(path))
            {
                NotifyEnduser("Found folder...", 10, false);
            }
            // If not then create it
            else
            {
                NotifyEnduser("Folder does not exist. Trying to create folder...", 10, false);
                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(path); // di.Delete() will delete it


                    NotifyEnduser("Success! Folder created", 10, false);
                }
                catch (Exception ex)
                {
                    
                    NotifyEnduser("Unable to create folder." + "\r\n" + "Exception is (next line):" + "\r\n" + ex.Message, 10, true);
                }
                finally {
                // silent
                }
            }

            // SAVE FILE
            NotifyEnduser("Trying to save file as:", 10, false);
            try
            {
                string myImg = (path + "\\" + myUniqueFileName + ".png");
                bmpScreenshot.Save(myImg, ImageFormat.Png);

                NotifyEnduser("Success! File saved to location:\r\n\r\n" + myImg, 10, false);
            }
            catch (Exception ex)
            {
                
                NotifyEnduser("Unable to save file." + "\r\n" + "Exception is (next line):" + "\r\n" + ex.Message, 10, true);
            }
        }

        // ################################
        // IE CACHE CLEANER TOOL
        // ################################

        // counters to keep track on IE cache deletion
        int DelCountErrFile, DelCountErrFolder, DelCountFile, DelCountFolder;

        // Count InternetCache items
        private void emptyBrowserIECacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCountErrFile = 0;
            DelCountErrFolder = 0;
            DelCountFile = 0;
            DelCountFolder = 0;

            clearIECache();
            
            NotifyEnduser("Task Completed: " + "\r\n"
                          + "Files     :  " + DelCountFile + " files deleted. (" + DelCountErrFile.ToString() + " failed)" + "\r\n"
                          + "Folders   :  " + DelCountFolder + " folders deleted. (" + DelCountErrFolder.ToString() + " failed)" + "\r\n"
                          , 10, false);
        }

        // Getting directory information from object
        private void clearIECache()
        {
            ClearFolder(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)));
        }

        // DELETE CACHE
        private void ClearFolder(DirectoryInfo folder)
        {
             // Deleting files
            foreach (FileInfo file in folder.GetFiles())
            {
                try
                {
                    file.Delete();
                    DelCountFile++;
                }
                catch (Exception)
                {
                    DelCountErrFile++;
                }
            }

            // Deleting folders
            foreach (DirectoryInfo subfolder in folder.GetDirectories())
            {
                try
                {
                    ClearFolder(subfolder);
                    DelCountFolder++;
                }
                catch (Exception)
                {
                    DelCountErrFolder++;
                }
            }

        }

        // ################################
        // RIGHT CLICK MENU ITEMS
        // ################################


        // PAGE DETAILS
        private void webpageInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pageDetails = "";

            pageDetails = pageDetails + "Title: " + webBrowser1.DocumentType.ToString() + "\r\n";
            pageDetails = pageDetails + "Type: " + webBrowser1.DocumentTitle.ToString() + "\r\n";
            pageDetails = pageDetails + "Encryption: " + webBrowser1.EncryptionLevel.ToString() + "\r\n";
            pageDetails = pageDetails + ": " + webBrowser1.Url.ToString() + "\r\n";

            NotifyEnduser(pageDetails, 10, false);
        }

        // PAGE PRINT
        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        // PAGE PROPERTIES
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        // PAGE SAVE AS...
        private void savePageAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        // PAGE REFRESH
        private void refreshPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        // LAUNCH IE INTERNET OPTIONS (CONTROL PANEL)
        private void internetOptionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process internetoptions = new Process();
            internetoptions.StartInfo.FileName = "inetcpl.cpl";
            internetoptions.Start();
        }

        // PAGE PRINT PREVIEW
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }


        // EXIT APPLICATION
        public void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // RECYCLE APPLICATION DATA
        public void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchSettings();
        }


    }
}