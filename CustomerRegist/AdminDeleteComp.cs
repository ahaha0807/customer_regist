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
    public partial class AdminDeleteComp : Form
    {
        private MenuList menuList;
        private AdminAddition adminAddition;
        private AdminDelete adminDelete;

        public AdminDeleteComp()
        {
            InitializeComponent();
        }

        public AdminDeleteComp(MenuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }

        public AdminDeleteComp(MenuList menuList, AdminDelete adminDelete)
        {
            InitializeComponent();
            this.menuList = menuList;
            this.adminDelete = adminDelete;
        }

        private void deleteComp_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDelete.Close();
            menuList.Show();
        }
    }
}
