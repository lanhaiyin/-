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
    public partial class hjxgsc : Form
    {
        public hjxgsc()
        {
            InitializeComponent();
        }
        Classhj hj = new Classhj();
        private void hjxg_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            hj.jz(dg);
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = e.RowIndex;
            if (sum >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 0)//点击在修改按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        hj.xg(dg,dg.Rows[sum].Cells[2].Value.ToString(),sum);
                }
                if (e.ColumnIndex == 1)//点击在删除按钮上
                {
                    if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hj.sc(dg, dg.Rows[sum].Cells[2].Value.ToString());
                    }
                }
            }
        }
    }
}
