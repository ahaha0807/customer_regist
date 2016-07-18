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

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            customerRegi.Show();
        }
    }
}
