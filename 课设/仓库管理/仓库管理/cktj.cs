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
    public partial class cktj : Form
    {
        public cktj()
        {
            InitializeComponent();
        }
        ckb c = new ckb();
        khb k = new khb();
        Classcktj ck = new Classcktj();
        Validator yz = new Validator();
        int num;
        private void cktj_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            ck.DataBindingCmbckSpm(cmbspm);
            cmbspm.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            ck.DataBindingCmbckSpxh(cmdxh,c);
            cmdxh.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbckcfhj(cmbhj,c);
            cmbhj.SelectedIndex = 0;

            ck.DataBindingCmbckshr(cmbshr);
            cmbshr.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.cfhj = cmbhj.SelectedValue.ToString();
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbcksl(c);
            sl.Text = "最多" + c.sl.ToString();
        }

        private void cmbspm_Leave(object sender, EventArgs e)
        {
            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            ck.DataBindingCmbckSpxh(cmdxh,c);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!yz.IsNumber(txbsl.Text) || int.Parse(txbsl.Text)>c.sl)
            {
                MessageBox.Show("数量输入有误");
                return;
            }

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.spm = cmbspm.Text;
            c.sl = int.Parse(txbsl.Text);
            c.xh = cmdxh.SelectedValue.ToString();
            c.chr = dlshuju.dlzh;
            c.shr = cmbshr.SelectedValue.ToString();
            c.cfhj = cmbhj.SelectedValue.ToString();
            k.kh = cmbshr.Text;
            ck.Insertrktj(c);
            ck.DataBindingDataGridView(dgvck, num, c, k);
            num++;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.cfhj = cmbhj.SelectedValue.ToString();
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbcksl(c);
            sl.Text = "最多" + c.sl.ToString();
        }

        private void cmdxh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbckcfhj(cmbhj, c);
            cmbhj.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.cfhj = cmbhj.SelectedValue.ToString();
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbcksl(c);
            sl.Text = "最多" + c.sl.ToString();
        }

        private void cmbspm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            ck.DataBindingCmbckSpxh(cmdxh, c);
            cmdxh.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbckcfhj(cmbhj, c);
            cmbhj.SelectedIndex = 0;

            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.cfhj = cmbhj.SelectedValue.ToString();
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbcksl(c);
            sl.Text = "最多" + c.sl.ToString();
        }

        private void cmbhj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            c.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            c.cfhj = cmbhj.SelectedValue.ToString();
            c.xh = cmdxh.SelectedValue.ToString();
            ck.DataBindingCmbcksl(c);
            sl.Text = "最多" + c.sl.ToString();
        }
    }
}
