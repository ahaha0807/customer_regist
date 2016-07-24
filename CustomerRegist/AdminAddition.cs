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
    public partial class AdminAddition : Form
    {
        private MenuList menuList;
        private Login login;

        public AdminAddition()
        {
            InitializeComponent();
        }

        public AdminAddition(MenuList menuList, Login login)
        {
            InitializeComponent();
            this.menuList = menuList;
            this.login = login;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menuList.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (addUserName.Text != "") //ユーザ名が空でないか
            {
                if (addUserPass.Text == addUserPassConti.Text)  //二度入力したPWが一致しているか
                {
                    addUserInfo.Text = "";

                    OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database_1.accdb;");
                    OleDbCommand sql = new OleDbCommand("INSERT INTO loginTable(userName, userPass) VALUES(@name, @pass)", connect);

                    sql.Parameters.Add("@name", OleDbType.VarChar);
                    sql.Parameters["@name"].Value = addUserName.Text;
                    sql.Parameters.Add("@pass", OleDbType.VarChar);
                    sql.Parameters["@pass"].Value = addUserPass.Text;

                    
                    try
                    {
                        connect.Open();

                        if(sql.ExecuteNonQuery() > 0){  //登録が成功したか
                            this.Close();
                            AddUserConf auc = new AddUserConf(menuList);
                            auc.Show();
                        }

                    }
                    catch (OleDbException)
                    {
                        addUserInfo.Text = "ユーザー名が既に存在しているため、登録できませんでした";
                    }
                    finally
                    {
                        connect.Close();
                    }

                    }
                else
                {
                    addUserInfo.Text = "入力されたパスワードが一致しません";
                }
            }
            else
            {
                addUserInfo.Text = "ユーザー名を空にすることはできません";
            }
        }
    }
}
