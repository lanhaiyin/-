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
    public partial class spkc : Form
    {
        public spkc()
        {
            InitializeComponent();
        }
        Classspkc kc = new Classspkc();
        private void spkc_Load(object sender, EventArgs e)
        {
            DataTable tc = new DataTable();
            tc=kc.cx(dg);
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            Label[] lab = new Label[tc.Rows.Count];
            for (int i = 0; i < tc.Rows.Count; i++)
            {
                lab[i] = new Label();
                lab[i].Location = new Point(550, (i+1)* 40);
                lab[i].Text = tc.Rows[i][0].ToString() + "规格为：" + tc.Rows[i][1].ToString() + "的数量为" + tc.Rows[i][2].ToString();
                lab[i].Size = new Size(100,25);
                this.Controls.Add(lab[i]);
            }
        }
    }
}
