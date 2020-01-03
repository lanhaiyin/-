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
    public partial class ckdh : Form
    {
        public ckdh()
        {
            InitializeComponent();
        }

        private void boxcx_Click(object sender, EventArgs e)
        {
            cx.dhcx(dg, int.Parse(comboxrkdh.SelectedValue.ToString()), "select * from ckdh where ckbh=@ckbh", "@ckbh");
            dg.Columns[0].HeaderText = "出库单号";
            dg.Columns[1].HeaderText = "商品名";
            dg.Columns[2].HeaderText = "规格";
            dg.Columns[3].HeaderText = "数量";
            dg.Columns[4].HeaderText = "出库货架";
            dg.Columns[5].HeaderText = "入库人";
            dg.Columns[6].HeaderText = "收货人";
            dg.Columns[7].HeaderText = "出库时间";
            dg.Columns[8].Visible = false;
        }
        Classdh cx = new Classdh();
        private void ckdh_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            cx.bh(comboxrkdh, "select * from ckdh", "ckbh", "ckbh");
        }
    }
}
