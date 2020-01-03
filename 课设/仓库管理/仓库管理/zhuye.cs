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
    public partial class zhuye : Form
    {
        public zhuye()
        {
            InitializeComponent();
        }
        Classzhuye zy = new Classzhuye();
        private void zhuye_Load(object sender, EventArgs e)
        {

        }

        private void 入库添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr=new rktj();
            fr.MdiParent=this;
            fr.Show();
        }

        private void 入库验证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new rkyz();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 出库添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new cktj();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 出库检阅ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new ckyz();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void 商品录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new splr();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this); 
            Form fr = new tjyh();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new xgmm();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new scyh();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 修改用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new xgyh();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 商品库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new spkc();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 订单号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new rkdh();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 出库号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new ckdh();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 日期查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new rqcx();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 货架情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new hjqk();
            fr.MdiParent = this;
            fr.Show();
        }


        private void 商品修改与删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new spxgsc();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 货架输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new hjsr();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 货架修改删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zy.b(this);
            Form fr = new hjxgsc();
            fr.MdiParent = this;
            fr.Show();
        }


    }
}
