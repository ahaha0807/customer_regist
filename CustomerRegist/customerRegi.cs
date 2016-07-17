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
    public partial class customerRegi : Form
    {
        private menuList menuList;

        public customerRegi(menuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }
    }
}
