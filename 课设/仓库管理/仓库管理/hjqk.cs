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
    public partial class hjqk : Form
    {
        public hjqk()
        {
            InitializeComponent();
        }
        Classhjqk cx = new Classhjqk();
        private void toncx_Click(object sender, EventArgs e)
        {
            cx.cx(dg,comboxhjbh.Text);
        }

        private void hjqk_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            cx.bh(comboxhjbh);
        }
    }
}
