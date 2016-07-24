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
    public partial class AdminDeleteConf : Form
    {
        private MenuList menuList;
        private AdminAddition adminAddition;
        private AdminDelete adminDelete;
        private String adminUserNameBox;
        private String adminUserNameBoxConti;
        private TextBox deleteUserName;
        private AdminDelete AdminDelete;
        private TextBox adminUserNameBox1;
        private TextBox adminPassBox;

        public AdminDeleteConf()
        {
            InitializeComponent();
        }

        public AdminDeleteConf(MenuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }

        public AdminDeleteConf(CustomerRegist.AdminDelete adminDelete, TextBox adminUserNameBox1, TextBox adminPassBox, MenuList menuList)
        {
            InitializeComponent();
            this.adminDelete = adminDelete;
            this.adminUserNameBox1 = adminUserNameBox1;
            this.adminPassBox = adminPassBox;
            this.menuList = menuList;
        }       

        

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database_1.accdb;");
            OleDbCommand delete = new OleDbCommand("DELETE FROM loginTable WHERE userName = @name", connect);
            OleDbCommand pass = new OleDbCommand("SELECT * FROM loginTable WHERE userName = @id", connect);
            
            //DELETE文用
            delete.Parameters.Add("@name", OleDbType.VarChar);
            delete.Parameters["@name"].Value = adminUserNameBox1.Text;
            //パスワード確認用SELECT文用
            pass.Parameters.Add("@id", OleDbType.VarChar);
            pass.Parameters["@id"].Value = adminUserNameBox1.Text;

            try
            {
                connect.Open();

                OleDbDataReader data = pass.ExecuteReader();
                data.Read();

                //TODO: なんかこの辺でログインユーザーの行がラス１だったら削除できなくする処理書きたい

                if (data.GetString(1) == adminPassBox.Text) //AdminDelete画面で入力されたPWと対象のユーザーのPWが一致するか
                {
                    if (delete.ExecuteNonQuery() > 0)   //削除が成功したか否か
                    {
                        this.Close();
                        AdminDeleteComp adc = new AdminDeleteComp(menuList,  adminDelete);
                        adc.Show();
                    }
                    else
                    {
                        deleteUserInfo.Text = "ユーザーが存在しないかパスワードが間違っているため、削除できませんでした";
                    }
                }
                else
                {
                    deleteUserInfo.Text = "ユーザーが存在しないかパスワードが間違っているため、削除できませんでした";
                }

            }
            catch (OleDbException)
            {
                deleteUserInfo.Text = "何らかの原因によってユーザーの削除ができませんでした";
            }
            catch (InvalidOperationException)
            {
                deleteUserInfo.Text = "ユーザーが存在しないかパスワードが間違っているため、削除できませんでした";
            }
            finally
            {
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDelete.Show();
        }
    }
}
