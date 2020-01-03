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
    public partial class scyh : Form
    {
        public scyh()
        {
            InitializeComponent();
        }
        Classscyh cr = new Classscyh();
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 3)//点击在删除按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string zh;
                        zh = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cr.sc(zh, e.RowIndex,dg);
                        
                    }
                }
            }
        }
        
        private void scyh_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            cr.cr(dg);
        }
    }
}
