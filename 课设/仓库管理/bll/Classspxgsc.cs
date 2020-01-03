using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using dal;
using model;

namespace bll
{
    public class Classspxgsc
    {
        sjk sjk = new sjk();
        public void jz(DataGridView dg,DataGridView dg2)
        {
            DataTable dt = new DataTable();
            dt = sjk.Select("select spm,xh from sp where zt=1");
            dg.DataSource = dt;
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dg.Columns[2].ReadOnly = true;
            DataTable dt2 = new DataTable();
            dt2 = sjk.Select("select spm from spb where zt=1");
            dg2.DataSource = dt2;
            for (int i = 0; i < dg2.Columns.Count; i++)
            {
                dg2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dg.Columns[2].HeaderText = "商品名";
            dg.Columns[3].HeaderText = "型号";
            dg2.Columns[2].HeaderText = "商品名";
        }
        public void xg2(DataGridView dg, spxx l, int row)
        {
            bool t;
            DataTable dt = new DataTable();
            sjk.AddParameters("@spm", SqlDbType.NVarChar, l.spm);
            dt = sjk.Select("select xh from sp where spm=@spm and zt=1");
            if (dt.Rows.Count > 0)
            {
                 MessageBox.Show("此商品还有商品型号，不能进行修改！");
                 return;
            }
            DataTable dt2 = new DataTable();
            dt2 = sjk.Select("SELECT spm FROM spb where zt=1");
            DataTable dt3 = new DataTable();
            sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
            dt3 = sjk.Select("SELECT * FROM sp where spm=@spm");
            if (dt3.Rows.Count > 0)
            {
                if (dt3.Rows[0]["zt"].ToString() == "0")
                {
                    if (MessageBox.Show("数据库中已有该型号但被注销\n需要还原该型号吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sjk.AddParameters("@yspm", SqlDbType.VarChar, dt2.Rows[row][0]);
                        sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
                        sjk.Up("update sp set zt=1  where spm=@spm");
                        sjk.Delete("delete from sp where and spm=@yspm");
                        MessageBox.Show("用户修改成功！");
                        return;
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("已有该商品名,不能进行修改！");
                    return;
                }
            } 
            sjk.AddParameters("@yspm", SqlDbType.VarChar, dt2.Rows[row][0]);
            sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
            sjk.Up("update spb set spm=@spm  where spm=@yspm ");
            sjk.clear();
            MessageBox.Show("用户修改成功！");
            DataTable dt4 = new DataTable();
            dt4 = sjk.Select("select spm from spb where zt=1");
            dg.DataSource = dt4;
            return;
        }
        public void xg(DataGridView dg,spxx l,int row)
        {
            bool t = true;
            DataTable dt = new DataTable();
            dt = sjk.Select("SELECT xh FROM sp where zt=1");
            sjk.AddParameters("@yxh", SqlDbType.VarChar, dt.Rows[row][0]);
            sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
            DataTable dt2 = new DataTable();
            dt2=sjk.Select("SELECT sl FROM sp where zt=1 and spm=@spm and xh=@yxh");
            if (int.Parse(dt2.Rows[0][0].ToString())> 0)
            {
                MessageBox.Show("此型号商品还有库存，不能删除！");
                return;
            }
            
            DataTable dt3 = new DataTable();
            sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
            sjk.AddParameters("@xh", SqlDbType.VarChar, l.xh);
            dt3 = sjk.Select("SELECT * FROM sp where  xh=@xh and spm=@spm");
            if (dt3.Rows.Count >0)
            {
                if (dt3.Rows[0]["zt"].ToString() == "0")
                {
                    if (MessageBox.Show("数据库中已有该型号但被注销\n需要还原该型号吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sjk.AddParameters("@yxh", SqlDbType.VarChar, dt.Rows[row][0]);
                        sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
                        sjk.AddParameters("@xh", SqlDbType.VarChar, l.xh);
                        sjk.Up("update sp set zt=1  where xh=@xh and spm=@spm");
                        sjk.Delete("delete from sp where xh=@yxh and spm=@spm");
                        MessageBox.Show("用户修改成功！");
                        return;
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("该商品已有该型号,不能进行修改！");
                    return;
                }
            }
            sjk.AddParameters("@yxh", SqlDbType.VarChar, dt.Rows[row][0]);
            sjk.AddParameters("@spm", SqlDbType.VarChar, l.spm);
            sjk.AddParameters("@xh", SqlDbType.VarChar, l.xh);
            sjk.Up("update sp set xh=@xh  where xh=@yxh and spm=@spm");
            sjk.clear();
            MessageBox.Show("用户修改成功！");
            DataTable dt4 = new DataTable();
            dt4 = sjk.Select("select spm,xh from sp where zt=1");
            dg.DataSource = dt4;

        }
        public void sc(DataGridView dg,int sum,string spm,string xh)
        {
            bool t;
            sjk.AddParameters("@spm",SqlDbType.NVarChar,spm);
            sjk.AddParameters("@xh",SqlDbType.NVarChar, xh);
            t=sjk.Up("update sp set zt=0 where spm=@spm and xh=@xh");
            if (t == false)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            MessageBox.Show("删除成功！");
            DataTable dt = new DataTable();
            dt = sjk.Select("select spm,xh from sp where zt=1");
            dg.DataSource = dt;
        }
        public void sc2(DataGridView dg,DataGridView dg2, int sum, string spm)
        {
            bool t;
            DataTable dt = new DataTable();
            sjk.AddParameters("@spm", SqlDbType.NVarChar, spm);
            dt = sjk.Select("select sl from sp where spm=@spm and zt=1");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["sl"].ToString()) >0)
                {
                    MessageBox.Show("此商品还有数量大于0的商品型号，请删除先删除该型号后在删除该商品");
                    return;
                }
            }
            sjk.AddParameters("@spm", SqlDbType.NVarChar, spm);
            t = sjk.Up("update spb set zt=0 where spm=@spm");
            if (t == false)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            sjk.Up("update sp set zt=0 where spm=@spm");
            MessageBox.Show("删除成功！");
            DataTable dt2 = new DataTable();
            dt = sjk.Select("select spm,xh from sp where zt=1");
            dg.DataSource = dt;
            dt2 = sjk.Select("select spm from spb where zt=1");
            dg2.DataSource = dt2;
            return;
            
        }
    }
}
