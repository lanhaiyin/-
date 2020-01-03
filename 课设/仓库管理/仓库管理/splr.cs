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
    public partial class splr : Form
    {
        public splr()
        {
            InitializeComponent();
        }
        Classsplr lr = new Classsplr();
        spxx s = new spxx();
        Validator yz = new Validator();
        int row=0;
        private void tonlr_Click(object sender, EventArgs e)
        {
            if (!yz.Isspm(boxspm.Text))
            {
                MessageBox.Show("请输入正确的商品名，商品名应最少两位中文且不能有空格！");
                return;
            }
            if (!yz.Isxh1(boxxh.Text) && !yz.Isxh3(boxxh.Text))
            {
                MessageBox.Show("请输入正确的规格，规格应由最少1位中文或最少1位中文和英文字母数字组成！");
                return;
            }
            s.spm = boxspm.Text;
            s.xh = boxxh.Text;
            row=lr.lr(s,dgvrk,row);
        }

        private void splr_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
        }
    }
}
