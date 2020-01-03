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
    public partial class rkyz : Form
    {
        public rkyz()
        {
            InitializeComponent();
        }
        Classrkyz yz = new Classrkyz();
        rkb r = new rkb();
        private void rkyz_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            yz.DataBindingDataGridView(dgvrkyz);
        }

        private void dgvrkyz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 6)//点击在入库按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认入库？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        r.spm = dgvrkyz.Rows[e.RowIndex].Cells[0].Value.ToString();
                        r.xh = dgvrkyz.Rows[e.RowIndex].Cells[1].Value.ToString();
                        r.sl = int.Parse(dgvrkyz.Rows[e.RowIndex].Cells[2].Value.ToString());
                        r.rkr = dgvrkyz.Rows[e.RowIndex].Cells[3].Value.ToString();
                        r.gys = dgvrkyz.Rows[e.RowIndex].Cells[4].Value.ToString();
                        r.cfhj = dgvrkyz.Rows[e.RowIndex].Cells[5].Value.ToString();
                        r.spbh = int.Parse(dgvrkyz.Rows[e.RowIndex].Cells[8].Value.ToString());
                        yz.dgvCellContentClickrk(r);
                        yz.Insertrkhj(r);
                        yz.Updaterktj(r);
                        MessageBox.Show("商品入库！");
                        dgvrkyz.Rows.RemoveAt(e.RowIndex);
                    }
                }
                if (e.ColumnIndex == 7)//点击在退货按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认退货？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        r.spm = dgvrkyz.Rows[e.RowIndex].Cells[0].Value.ToString();
                        r.xh = dgvrkyz.Rows[e.RowIndex].Cells[1].Value.ToString();
                        r.sl = int.Parse(dgvrkyz.Rows[e.RowIndex].Cells[2].Value.ToString());
                        r.rkr = dgvrkyz.Rows[e.RowIndex].Cells[3].Value.ToString();
                        r.gys = dgvrkyz.Rows[e.RowIndex].Cells[4].Value.ToString();
                        r.cfhj = dgvrkyz.Rows[e.RowIndex].Cells[5].Value.ToString();
                        yz.dgvCellContentClickth(r);
                        MessageBox.Show("退货成功！");
                        dgvrkyz.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
