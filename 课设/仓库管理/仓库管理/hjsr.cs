using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bll;
using model;
namespace 仓库管理
{
    public partial class hjsr : Form
    {
        public hjsr()
        {
            InitializeComponent();
        }
        Classhj hjbh = new Classhj();
        hj hj = new hj();
        Validator yz = new Validator();
        int row = 0;
        private void hjsr_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
        }

        private void tonlr_Click(object sender, EventArgs e)
        {
            if (!yz.Ishjbh(boxhjbh.Text))
            {
                MessageBox.Show("请输入正确的货架编号，货架编号第1位为大写英文字母接下来为1位数字或两位数字！");
                return;
            }
            hj.hjbh = boxhjbh.Text;
            hj.hjck = boxhjck.Text;
            row = hjbh.lr(hj, dg, row);
        }
    }
}
