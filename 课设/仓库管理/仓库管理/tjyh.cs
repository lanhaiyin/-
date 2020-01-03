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
    public partial class tjyh : Form
    {
        public tjyh()
        {
            InitializeComponent();
        }


        Validator yz = new Validator();
        dl dl=new dl();
        Classtjyh tj = new Classtjyh();
        int sum;

        private void tontj_Click(object sender, EventArgs e)
        {
            
            if (!yz.IsPassword(boxyhm.Text))
            {
                MessageBox.Show("帐号最少为3位，由纯英文或纯数据或英文和数字一起组成！");
                return;
            }
            if (!yz.IsPassword(boxmm.Text))
            {
                MessageBox.Show("密码最少为3位，由纯英文或纯数字或英文和数字一起组成！");
                return;
            }
            if (!yz.Isspm(boxxm.Text))
            {
                MessageBox.Show("姓名由最少两位汉字组成且无空格！");
                return;
            }
            dl.zh = boxyhm.Text;
            dl.mm = boxmm.Text;
            dl.xm = boxxm.Text;
            dl.qx = int.Parse(boxqx.Text);
            sum=tj.tj(dl,sum,dg);
        }

        private void tjyh_Load(object sender, EventArgs e)
        {
            boxqx.SelectedIndex = 0;
            Classzhuye zy = new Classzhuye();
            zy.a(this);
        }

    }
}
