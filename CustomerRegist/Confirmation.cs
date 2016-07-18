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
                string sql = "INSERT INTO customerTable (name, name_kana, zipcode, prefectures, city, other_address, tel, birthday)"
                    + "values (@name, @name_kana, @zipcode, @prefectures, @city, @other_address, @tel, @birthday)";
                OleDbCommand command = new OleDbCommand(sql, connect);

                connect.Open();
                command.ExecuteReader();
            }
            catch (OleDbException)
            {
                submitInfo.Text = "登録に失敗しました。";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            customerRegi.Show();
        }
    }
}
