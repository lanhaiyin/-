using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bll;

namespace 仓库管理
{
    public partial class rkdh : Form
    {
        public rkdh()
        {
            InitializeComponent();
        }
        Classdh cx = new Classdh();
        private void rkdh_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            cx.bh(comboxrkdh, "select * from rkdh", "rkbh", "rkbh");
        }

        private void boxcx_Click(object sender, EventArgs e)
        {
            cx.dhcx(dg, int.Parse(comboxrkdh.SelectedValue.ToString()),"select * from rkdh where rkbh=@rkbh", "@rkbh");
            dg.Columns[0].HeaderText = "入库单号";
            dg.Columns[1].HeaderText = "商品名";
            dg.Columns[2].HeaderText = "规格";
            dg.Columns[3].HeaderText = "数量";
            dg.Columns[4].HeaderText = "入库人";
            dg.Columns[5].HeaderText = "供应商";
            dg.Columns[6].HeaderText = "货架编号";
            dg.Columns[7].HeaderText = "入库时间";
            dg.Columns[8].Visible = false;
        }


    }
}
