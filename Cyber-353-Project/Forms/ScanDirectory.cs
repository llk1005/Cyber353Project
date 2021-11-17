using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using nClam;

namespace Cyber_353_Project
{
    public partial class ActivityMonitor : Form
    {
        public ActivityMonitor()
        {
            InitializeComponent();
        }

        private void ScanDirectoryBtn_Click(object sender, EventArgs e)
        {
            ClamClient clam = new ClamClient("localhost", 3310);

            switch (SelectDirectory.ShowDialog())
            // opens a Windows file dialog to select a file path or cancel operation
            {
                case DialogResult.OK:   // the user has selected a file path
                    string pathName = SelectDirectory.SelectedPath;
                    DirectoryInfo d = new DirectoryInfo(pathName);
                    FileInfo[] files = d.GetFiles();
                    SelectedDirLbl.Text = "Selected Directory: " + pathName;

                    foreach(FileInfo f in files)
                    {
                        var scanResult = await clam.ScanFileOnServerAsync("C:\\test.txt");  //any file you would like!

                        switch (scanResult.Result)
                        {
                            case ClamScanResults.Clean:
                                Console.WriteLine("The file is clean!");
                                break;
                            case ClamScanResults.VirusDetected:
                                Console.WriteLine("Virus Found!");
                                Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                                break;
                            case ClamScanResults.Error:
                                Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                                break;
                        }
                    }
                    
                    break;
                case DialogResult.Cancel:   // the user decided to cancel the operation
                    MessageBox.Show("The scan operation was cancelled.");
                    break;
                default:
                    // this should never execute, but out of caution, I'm putting a catch-all here
                    MessageBox.Show("The scan operation did not take place.");
                    break;

            }
        }
    }
}
