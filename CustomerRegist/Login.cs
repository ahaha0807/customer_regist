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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database_1.accdb;");
                OleDbCommand sql = new OleDbCommand("SELECT * FROM loginTable WHERE userName = @id", connect);

                sql.Parameters.Add("@id", OleDbType.VarChar);
                sql.Parameters["@id"].Value = userNameBox.Text;

                connect.Open();

                OleDbDataReader data = sql.ExecuteReader();
                data.Read();

                if (data.GetString(1) == userPassBox.Text)
                {
                    this.Hide();
                    menuList ml = new menuList(this);
                    ml.ShowDialog();
                    userNameBox.Text = "";
                    userPassBox.Text = "";
                    loginInfo.Text = "";
                }
                else
                {
                    loginInfo.Text = "ユーザー名・パスワードが間違っています";
                }
            }
            catch (InvalidOperationException)
            {
                loginInfo.Text = "ユーザー名・パスワードが間違っています";
            }



        }
    }
}
