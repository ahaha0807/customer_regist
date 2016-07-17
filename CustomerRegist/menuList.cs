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
    public partial class menuList : Form
    {
    private   Login login;
    public menuList(Login login)
    {
        this.login = login;
        InitializeComponent();
    }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void customerRegi_Click(object sender, EventArgs e)
        {
            this.Close();
            customerRegi cl = new customerRegi(this);
            cl.ShowDialog();
        }

        private void loginUserRegi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
