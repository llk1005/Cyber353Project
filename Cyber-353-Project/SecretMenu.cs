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
    public partial class SecretMenu : Form
    {
        public SecretMenu()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.Show();
        }

        private void ViewLoginBtn_Click(object sender, EventArgs e)
        {
            LoginDataView loginView = new LoginDataView();
            loginView.Show();
        }
    }
}
