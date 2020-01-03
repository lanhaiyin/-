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
    public partial class xgyh : Form
    {
        public xgyh()
        {
            InitializeComponent();
        }
        Classxgyh cr = new Classxgyh();
        dl dl = new dl();
        Validator yz = new Validator();
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 0)//点击在修改按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dl.zh = dg.Rows[e.RowIndex].Cells[1].Value.ToString();
                        dl.mm = dg.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dl.xm = dg.Rows[e.RowIndex].Cells[3].Value.ToString();
                        dl.qx = int.Parse(dg.Rows[e.RowIndex].Cells[4].Value.ToString());
                        if (!yz.Isuid(dl.zh))
                        {
                            MessageBox.Show("帐号最少为3位由字母和数字组成也可以只为字母或数字", "警告");
                            return;
                        }
                        if (!yz.IsPassword(dl.mm))
                        {
                            MessageBox.Show("密码最少为3位由字母和数字组成也可以只为字母或数字", "警告");
                            return;
                        }
                        if (!yz.Isspm(dl.xm))
                        {
                            MessageBox.Show("姓名由中文组成最少为两位", "警告");
                            return;
                        }
                        if (dl.qx!=1&&dl.qx!=2&&dl.qx!=3)
                        {
                            MessageBox.Show("权限错误能给予的权限有1-3", "警告");
                            return;
                        }
                        cr.xg(dl, e.RowIndex, dg);
                        
                    }
                }
            }
        }

        private void xgyh_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            cr.cr(dg);

        }
    }
}
