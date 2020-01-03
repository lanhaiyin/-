using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using dal;
using model;

namespace bll
{
    public class Classhj
    {
        sjk sjk = new sjk();
        public int lr(hj hj, DataGridView dg, int row)
        {
            DataTable dt=new DataTable();
            sjk.AddParameters("@hjbh", SqlDbType.VarChar, hj.hjbh);
            sjk.AddParameters("@hjck", SqlDbType.VarChar, hj.hjck);
            dt=sjk.Select("select*from hjb where hjbh=@hjbh and hjck=@hjck ");
            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0]["zt"].ToString()) == 0)
                {
                    if (MessageBox.Show("此货架已存在，但被注销，要恢复此货架吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sjk.AddParameters("@hjbh", SqlDbType.VarChar, hj.hjbh);
                        sjk.AddParameters("@hjck", SqlDbType.VarChar, hj.hjck);
                        sjk.Up("update hjb set zt=1 where hjbh=@hjbh and hjck=@hjck");
                        dg.Rows[row].Cells[0].Value = hj.hjbh;
                        dg.Rows[row].Cells[1].Value = hj.hjck;
                        dg.Rows[row].Cells[2].Value = "成功";
                        row++;
                        return row;
                    }
                    else
                        return row;
                }
                MessageBox.Show("已经有此型号无需输入！");
                dg.Rows.Add();
                dg.Rows[row].Cells[0].Value = hj.hjbh;
                dg.Rows[row].Cells[1].Value = hj.hjck;
                dg.Rows[row].Cells[2].Value = "失败";
                row++;
                return row;
            }
            else
            {
                sjk.AddParameters("@hjbh", SqlDbType.VarChar, hj.hjbh);
                sjk.AddParameters("@hjck", SqlDbType.VarChar, hj.hjck);
                sjk.Insert("insert into hjb(hjbh,hjck,zt) values(@hjbh,@hjck,1)");
                MessageBox.Show("插入成功！");
                dg.Rows.Add();
                dg.Rows[row].Cells[0].Value = hj.hjbh;
                dg.Rows[row].Cells[1].Value = hj.hjck;
                dg.Rows[row].Cells[2].Value = "成功";
                row++;
                return row;
            }

        }
        public void jz(DataGridView dg)
        {
            DataTable dt = new DataTable();
            dt = sjk.Select("select hjbh from hjb where zt=1");
            dg.DataSource = dt;
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dg.Columns[2].HeaderText = "货架编号";
        }
        public void xg(DataGridView dg,string hjbh, int row)
        {
            DataTable dt4 = new DataTable();
            sjk.AddParameters("@hjbh", SqlDbType.VarChar, hjbh);
            dt4 = sjk.Select("SELECT sl FROM hjxxb where zt=1 and hjbh=@hjbh");
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (int.Parse(dt4.Rows[i][0].ToString()) > 0)
                {
                    MessageBox.Show("此货架还存放着商品，不能删除！");
                    return;
                }
            }
            DataTable dt = new DataTable();
            dt = sjk.Select("SELECT hjbh FROM hjb where zt=1");
            DataTable dt2 = new DataTable();
            sjk.AddParameters("@hjbh", SqlDbType.VarChar, hjbh);
            dt2 = sjk.Select("SELECT * FROM hjb where hjbh=@hjbh");
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0]["zt"].ToString() == "0")
                {
                    if (MessageBox.Show("数据库中已有该货架但被注销\n需要还原该货架吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sjk.AddParameters("@hjbh", SqlDbType.VarChar, hjbh);
                        sjk.AddParameters("@yhjbh", SqlDbType.VarChar, dt.Rows[row][0].ToString());
                        sjk.Up("update hjb set zt=1  where hjbh=@hjbh");
                        sjk.Delete("delete from hjb where hjbh=@yhjbh");
                        MessageBox.Show("用户修改成功！");
                        return;
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("已有该货架,不能进行修改！");
                    return;
                }
            }
            sjk.AddParameters("@hjbh", SqlDbType.VarChar, hjbh);
            sjk.Up("update hjb set zt=1  where hjbh=@hjbh");
            sjk.clear();
            MessageBox.Show("用户修改成功！");
            DataTable dt5 = new DataTable();
            dt5 = sjk.Select("select hjbh from hjb where zt=1");
            dg.DataSource = dt5;
            return;
        }
        public void sc(DataGridView dg, string hjbh)
        {
            bool t;
            sjk.AddParameters("@hjbh", SqlDbType.NVarChar, hjbh);
            t = sjk.Up("update hjb set zt=0 where hjbh=@hjbh");
            if (t == false)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            else
            {
                MessageBox.Show("删除成功！");
                DataTable dt = new DataTable();
                dt = sjk.Select("select hjbh from hjb where zt=1");
                dg.DataSource = dt;
            }
        }
    }
}
