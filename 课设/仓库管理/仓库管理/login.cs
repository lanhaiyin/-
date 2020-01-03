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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Validator yz = new Validator();
        dl dl = new dl();
        Classlogin loginz = new Classlogin();
        private void dlton_Click(object sender, EventArgs e)
        {
            if (!yz.Isuid(zhbox.Text))
            {
                MessageBox.Show("请输入正确的帐号，帐号最少为3位由字母和数字组成也可以只为字母或数字！");
                return;
            }
            if (!yz.IsPassword(mmbox.Text))
            {
                MessageBox.Show("请输入正确的密码，密码最少为3位由字母和数字组成也可以只为字母或数字！");
                return;
            }
            dl.zh = zhbox.Text;
            dl.mm = mmbox.Text;
            Form fr = new zhuye();
            dlshuju.fr = fr;
            dlshuju.fr2 = this;
            loginz.dlz(this,fr,dl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
