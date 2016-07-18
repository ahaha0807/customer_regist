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
    public partial class CustomerRegi : Form
    {
        private MenuList menuList;
        private string[] prefectures = {
                                           "北海道", "青森県", "岩手県", "宮城県", "秋田県", 
                                           "山形県", "福島県", "茨城県", "栃木県", "群馬県", 
                                           "埼玉県", "千葉県", "東京都", "神奈川県", "新潟県", 
                                           "富山県", "石川県", "福井県", "山梨県", "長野県", 
                                           "岐阜県", "静岡県", "愛知県", "三重県", "滋賀県", 
                                           "京都府", "大阪府", "兵庫県", "奈良県", "和歌山県", 
                                           "鳥取県", "島根県", "岡山県", "広島県", "山口県", 
                                           "徳島県", "香川県", "愛媛県", "高知県", "福岡県", 
                                           "佐賀県", "長崎県", "熊本県", "大分県", "宮崎県", 
                                           "鹿児島県", "沖縄県"
                                       };
        private string[] city = {
                                    "市", "区", "町", "村"
                                };
        public CustomerRegi()
        {
            InitializeComponent();
        }

        public CustomerRegi(MenuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menuList.Show();
        }

        private void CustomerRegi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < prefectures.Length; i++ )
            {
                customerData6.Items.Add(prefectures[i]);
            }
            for (int i = 0; i < city.Length; i++)
            {
                customerData8.Items.Add(city[i]);
            }
        }

    }
}
