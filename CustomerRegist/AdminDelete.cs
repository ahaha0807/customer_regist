using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CustomerRegist
{
    public partial class AdminDelete : Form
    {
        private MenuList menuList;

        public AdminDelete()
        {
            InitializeComponent();
        }

        public AdminDelete(MenuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }

        private void adminDeleteButton_Click(object sender, EventArgs e)
        {
            if (adminUserNameBox.Text != "")    //ユーザー名が空でないか
            {
                if (adminUserNameBox.Text == adminUserNameConti.Text)   //二度入力したユーザ名が一致しているか
                {
                    adminDeleteInfo.Text = "";
                    this.Hide();
                    AdminDeleteConf adc = new AdminDeleteConf(this, adminUserNameBox, adminPassBox, menuList);
                    adc.Show();
                }
                else
                {
                    adminDeleteInfo.Text = "入力されたユーザー名が一致しません";
                }
            }
            else
            {
                adminDeleteInfo.Text = "ユーザー名を空にすることはできません";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menuList.Show();
        }
    }
}
