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
    public partial class Confirmation : Form
    {
        private CustomerRegi customerRegi;
        private string[] datas;
        private Login login;
        private MenuList menulist;

        public Confirmation()
        {
            InitializeComponent();
        }

        public Confirmation(CustomerRegi customerRegi, string[] datas)
        {
            InitializeComponent();
            this.customerRegi = customerRegi;
            this.datas = datas;
        }

        public Confirmation(CustomerRegi customerRegi, string[] datas, Login login, MenuList menulist)
        {
            InitializeComponent();
            this.customerRegi = customerRegi;
            this.datas = datas;
            this.login = login;
            this.menulist = menulist;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            Data_Print();
        }

        private void Data_Print()
        {
            customerData1.Text = datas[0];
            customerData2.Text = datas[1];
            customerData3.Text = datas[2];
            customerData4.Text = datas[3];
            customerData5.Text = datas[4];
            customerData6.Text = datas[5];
            customerData7.Text = datas[6];
            customerData8.Text = datas[7];
            customerData9.Text = datas[8];
            customerData10.Text = datas[9];
            customerData11.Text = datas[10];
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database_1.accdb;");
                string sql = "INSERT INTO customerTable (name, name_kana, zipcode, address, tel, birthday)"
                    + "VALUES (@name, @name_kana, @zipcode, @address, @tel, @birthday)";

                OleDbCommand command = new OleDbCommand(sql, connect);

                command = Set_Values(command);

                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (OleDbException)
            {
                submitInfo.Text = "登録に失敗しました。入力内容を確認してください。";
            }
                this.Close();
                Completion cmp = new Completion(login, menulist);
                cmp.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            customerRegi.Show();
        }

        private OleDbCommand Set_Values(OleDbCommand _command){

            OleDbCommand command = _command;

            command.Parameters.Add("@name", OleDbType.VarChar);
            command.Parameters["@name"].Value = customerData1.Text + customerData2.Text;

            command.Parameters.Add("@name_kana", OleDbType.VarChar);
            command.Parameters["@name_kana"].Value = customerData3.Text + customerData4.Text;

            command.Parameters.Add("@zipcode", OleDbType.VarChar);
            command.Parameters["@zipcode"].Value = customerData5.Text;

            command.Parameters.Add("@address", OleDbType.VarChar);
            command.Parameters["@address"].Value = customerData7.Text + customerData7.Text + customerData9.Text;

            command.Parameters.Add("@tel", OleDbType.VarChar);
            command.Parameters["@tel"].Value = customerData10.Text;
            command.Parameters.Add("@birthday", OleDbType.VarChar);
            command.Parameters["@birthday"].Value = customerData11.Text;
            
            return command;
        }
    }
}
