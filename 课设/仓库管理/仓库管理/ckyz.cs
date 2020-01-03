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
    public partial class ckyz : Form
    {
        public ckyz()
        {
            InitializeComponent();
        }
        Classckyz yz = new Classckyz();
        ckb c = new ckb();
        private void ckyz_Load(object sender, EventArgs e)
        {
            Classzhuye zy = new Classzhuye();
            zy.a(this);
            yz.DataBindingDataGridViewckyz(dgvck);
        }

        private void dgvck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//不是点击在标题栏上
            {
                if (e.ColumnIndex == 6)//点击在删除按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否确认出库？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        c.spm = dgvck.Rows[e.RowIndex].Cells[0].Value.ToString();
                        c.xh = dgvck.Rows[e.RowIndex].Cells[1].Value.ToString();
                        c.sl = int.Parse(dgvck.Rows[e.RowIndex].Cells[2].Value.ToString());
                        c.cfhj = dgvck.Rows[e.RowIndex].Cells[3].Value.ToString();
                        c.chr = dgvck.Rows[e.RowIndex].Cells[4].Value.ToString();
                        c.shr = dgvck.Rows[e.RowIndex].Cells[5].Value.ToString();
                        c.spbh = int.Parse(dgvck.Rows[e.RowIndex].Cells[8].Value.ToString());
                        c.ckbh = int.Parse(dgvck.Rows[e.RowIndex].Cells[9].Value.ToString());
                        int i=yz.dgvCellContentClickrk(c);
                        if (i == 2)
                        {
                            yz.Insertckhj(c);
                            yz.Updatecktj(c);
                            MessageBox.Show("成功出库");
                            dgvck.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("出库失败");
                        }
                    }
                }
                if (e.ColumnIndex == 7)//点击在删除按钮上
                {
                    //敏感操作必须先要提示，让用户确认后才能执行
                    if (MessageBox.Show("是否取消出库？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        c.spm = dgvck.Rows[e.RowIndex].Cells[0].Value.ToString();
                        c.xh = dgvck.Rows[e.RowIndex].Cells[1].Value.ToString();
                        c.sl = int.Parse(dgvck.Rows[e.RowIndex].Cells[2].Value.ToString());
                        c.cfhj = dgvck.Rows[e.RowIndex].Cells[3].Value.ToString();
                        c.chr = dgvck.Rows[e.RowIndex].Cells[4].Value.ToString();
                        c.shr = dgvck.Rows[e.RowIndex].Cells[5].Value.ToString();
                        c.spbh = int.Parse(dgvck.Rows[e.RowIndex].Cells[8].Value.ToString());
                        c.ckbh = int.Parse(dgvck.Rows[e.RowIndex].Cells[9].Value.ToString());

                        yz.dgvCellContentClickth(c);             
                        MessageBox.Show("取消出库！");
                        dgvck.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

    }
}
