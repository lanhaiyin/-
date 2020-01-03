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
    public partial class rktj : Form
    {
        public rktj()
        {
            InitializeComponent();
        }
        Validator yz = new Validator();
        Classrktj rk = new Classrktj();
        rkb r = new rkb();
        gysb g = new gysb();
        
        string gysxm;
        int num;

        private void rktj_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            rk.DataBindingCmbSpm(cmbspm);
            rk.DataBindingCmbgys(cmbgys);
            rk.DataBindingCmbcfhj(cmbhj);
        }

        private void cmbspm_Leave(object sender, EventArgs e)
        {
            r.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            rk.DataBindingCmbSpxh(cmbxh, r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!yz.IsNumber(txbsl.Text))
            {
                MessageBox.Show("数量输入有误");
                return;
            }
            r.spbh = int.Parse(cmbspm.SelectedValue.ToString());
            r.spm = cmbspm.Text;
            r.sl = int.Parse(txbsl.Text);
            r.xh = cmbxh.SelectedValue.ToString();
            r.rkr = dlshuju.dlzh;
            r.gysbh = int.Parse(cmbgys.SelectedValue.ToString());
            g.gys = cmbgys.Text;
            r.cfhj = cmbhj.SelectedValue.ToString();
            rk.Insertrktj(r);
            rk.DataBindingDataGridView(dgvrk, num, r, g);
            num++;
        }
    }
}
