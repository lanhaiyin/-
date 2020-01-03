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
    public partial class xgmm : Form
    {
        public xgmm()
        {
            InitializeComponent();
        }
        Validator yz = new Validator();
        mm mm = new mm();
        Classxgmm xg = new Classxgmm();
        private void tontj_Click(object sender, EventArgs e)
        {
            if (!yz.IsPassword(boxymm.Text))
            {
                MessageBox.Show("密码最少为3位，由纯英文或纯数字或英文和数字一起组成！");
                return;
            }
            if (!yz.IsPassword(boxxmm.Text))
            {
                MessageBox.Show("密码最少为3位，由纯英文或纯数字或英文和数字一起组成！");
                return;
            }
            if (boxxmm.Text != boxqrxmm.Text)
            {
                MessageBox.Show("确认密码与新密码不相等！");
                return;
            }
            mm.ymm = boxymm.Text;
            mm.xmm = boxxmm.Text;
            xg.tj(mm, this);
        }

        private void xgmm_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
        }
    }
}
