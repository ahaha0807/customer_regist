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
    public partial class Completion : Form
    {
        private Login login;
        private MenuList menulist;

        public Completion()
        {
            InitializeComponent();
        }

        public Completion(Login login, MenuList menulist)
        {
            InitializeComponent();
            this.login = login;
            this.menulist = menulist;
        }

        private void regiBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuList ml = new MenuList(login);
            CustomerRegi cr = new CustomerRegi(menulist);
            cr.Show();
        }

        private void menuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuList ml = new MenuList(login);
            ml.Show();
        }
    }
}
