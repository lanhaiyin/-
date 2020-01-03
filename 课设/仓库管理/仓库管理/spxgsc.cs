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
    public partial class spxgsc : Form
    {
        public spxgsc()
        {
            InitializeComponent();
        }
        Classspxgsc sp = new Classspxgsc();
        Validator yz = new Validator();
        spxx l = new spxx();
        private void spsc_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            sp.jz(dg,dg2);

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum=e.RowIndex;
            if ( sum>= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 0)//点击在修改按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!yz.Isxh1(dg.Rows[e.RowIndex].Cells[3].Value.ToString()) && !yz.Isxh3(dg.Rows[e.RowIndex].Cells[3].Value.ToString()))
                        {
                            MessageBox.Show("请输入正确的规格，规格应由最少1位中文或最少1位中文和英文字母数字组成！");
                            return;
                        }
                        l.spm = dg.Rows[e.RowIndex].Cells[2].Value.ToString();
                        l.xh = dg.Rows[e.RowIndex].Cells[3].Value.ToString();
                        sp.xg(dg,l,sum);
                    }
                }
                if (e.ColumnIndex == 1)//点击在删除按钮上
                {
                    if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sp.sc(dg,sum, dg.Rows[sum].Cells[2].Value.ToString(), dg.Rows[sum].Cells[3].Value.ToString());
                    }
                }
            }
                     
        }

        private void dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = e.RowIndex;
            if (sum >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 0)//点击在修改按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        l.spm = dg2.Rows[e.RowIndex].Cells[2].Value.ToString();
                        sp.xg2(dg2, l, sum);
                    }
                }
                if (e.ColumnIndex == 1)//点击在删除按钮上
                {
                    if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sp.sc2(dg,dg2, sum, dg2.Rows[sum].Cells[2].Value.ToString());
                    }
                }
            }
        }
    }
}
