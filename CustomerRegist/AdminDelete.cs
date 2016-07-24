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
            if (adminUserNameBox.Text != "")
            {
                if (adminUserNameBox.Text == adminUserNameConti.Text)
                {
                    adminDeleteInfo.Text = "";

                    OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database_1.accdb;");
                    OleDbCommand sql = new OleDbCommand("DELETE FROM loginTable WHERE userName = @name", connect);

                    sql.Parameters.Add("@name", OleDbType.VarChar);
                    sql.Parameters["@name"].Value = adminUserNameBox.Text;

                    try
                    {
                        connect.Open();

                        if (sql.ExecuteNonQuery() != 0)
                        {
                            this.Close();
                            AddUserConf auc = new AddUserConf(menuList);
                            auc.Show();
                        }

                    }
                    catch (OleDbException)
                    {
                        adminDeleteInfo.Text = "";
                    }
                    finally
                    {
                        connect.Close();
                    }

                    //登録されたがユーザーidが存在する場合エラーを吐く
                    //もしくは、そのidのpwを編集する
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
    }
}
