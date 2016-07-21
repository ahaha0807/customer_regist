using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRegist
{
    public partial class MenuList : Form
    {
    private   Login login;
    public MenuList(Login login)
    {
        this.login = login;
        InitializeComponent();
    }

    public MenuList()
    {
        InitializeComponent();
    }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void customerRegi_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegi cr = new CustomerRegi(this, login);
            cr.ShowDialog();
        }

        private void loginUserRegi_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddition aa = new AdminAddition(this, login);
            aa.Show();
        }
    }
}
