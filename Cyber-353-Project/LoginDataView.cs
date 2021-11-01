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
    public partial class LoginDataView : Form
    {
        public LoginDataView()
        {
            InitializeComponent();
        }

        private void loginDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void LoginDataView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.LoginData' table. You can move, or remove it, as needed.
            this.loginDataTableAdapter.Fill(this.database1DataSet.LoginData);
            // TODO: This line of code loads data into the 'database1DataSet.LoginData' table. You can move, or remove it, as needed.
            this.loginDataTableAdapter.Fill(this.database1DataSet.LoginData);
            // TODO: This line of code loads data into the 'database1DataSet.LoginData' table. You can move, or remove it, as needed.
            this.loginDataTableAdapter.Fill(this.database1DataSet.LoginData);

        }

        private void loginDataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.loginDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void loginDataBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.loginDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
