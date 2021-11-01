using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_353_Project
{
    public partial class ActivityMonitor : Form
    {
        public ActivityMonitor()
        {
            InitializeComponent();
        }

        private void SelectDirBtn_Click(object sender, EventArgs e)
        {
            switch (ActivityScanDirectory.ShowDialog())
            // opens a Windows file dialog to select a file path or cancel operation
            {
                case DialogResult.OK:   // the user has selected a file path
                    string pathName = ActivityScanDirectory.SelectedPath;
                    /*
                     * TODO: Figure out how to implement scan
                     * 
                     * The plan is to have the user select a filepath, then we call an API (tbd) that will
                     * perform the scan and return results to us.  If it tells us that there is a virus, we call the
                     * notification handler
                     */
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
