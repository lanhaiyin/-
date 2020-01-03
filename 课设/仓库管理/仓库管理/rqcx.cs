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
    public partial class rqcx : Form
    {
        public rqcx()
        {
            InitializeComponent();
        }
        Classrqcx cx = new Classrqcx();
        private void toncx_Click(object sender, EventArgs e)
        {
            cx.cx(dg,dg2,dateTimecx.Value.Date);
            dg.Columns[0].HeaderText = "入库单号";
            dg.Columns[1].HeaderText = "商品名";
            dg.Columns[2].HeaderText = "规格";
            dg.Columns[3].HeaderText = "数量";
            dg.Columns[4].HeaderText = "入库人";
            dg.Columns[5].HeaderText = "供应商";
            dg.Columns[6].HeaderText = "货架编号";
            dg.Columns[7].HeaderText = "入库时间";
            dg.Columns[8].Visible = false;
            dg2.Columns[0].HeaderText = "出库单号";
            dg2.Columns[1].HeaderText = "商品名";
            dg2.Columns[2].HeaderText = "规格";
            dg2.Columns[3].HeaderText = "数量";
            dg2.Columns[4].HeaderText = "出库货架";
            dg2.Columns[5].HeaderText = "入库人";
            dg2.Columns[6].HeaderText = "收货人";
            dg2.Columns[7].HeaderText = "出库时间";
            dg2.Columns[8].Visible = false;
        }

        private void rqcx_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
        }
    }
}
