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
    public partial class ActivityWindow : Form
    {
        public ActivityWindow()
        {
            InitializeComponent();
        }

        private void CheckDirBtn_Click(object sender, EventArgs e)
        {
            if (ActivityDirectorySelect.ShowDialog() == DialogResult.OK)    // user has selected a filepath
            {
                // TODO: Scan folder
                /*
                 * Here, the plan is to take the filepath selected by the IT professional and 
                 * call the virus scanning function, which will be accessed through an API
                 * 
                 */
            }
            else
            {
                MessageBox.Show("Folder Scan was cancelled");
            }
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
