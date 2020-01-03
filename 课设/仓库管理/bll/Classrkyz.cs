using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dal;
using model;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bll
{
    public class Classrkyz
    {
        sjk db = new sjk();
        SqlDataReader dtrkyz;
        int recordnumber;
        public void DataBindingDataGridView(DataGridView dgvrk)
        {
            //组合框的绑定
            dtrkyz = db.Select2("SELECT dbo.rkb.spm, dbo.rkb.xh, dbo.rkb.sl, dbo.rkb.rkr, dbo.gysb.gys, dbo.rkb.hjbh, dbo.rkb.spbh FROM dbo.gysb INNER JOIN dbo.rkb ON dbo.gysb.gysbh = dbo.rkb.gysbh where yz=1");
            //从SqlDataReader对象中读取记录的方法
            while (dtrkyz.Read())//每次读取一行，记录会自动下移至下一条记录，反复读取，直到读完记录
            {
                dgvrk.Rows.Add();//在DataGridView控件中添加一行
                //读取当前SqlDataReader对象中记录内容，将内容送到DataGridView指定记录和字段（行和列）中显示
                dgvrk.Rows[recordnumber].Cells[0].Value = dtrkyz[0];
                dgvrk.Rows[recordnumber].Cells[1].Value = dtrkyz[1];
                dgvrk.Rows[recordnumber].Cells[2].Value = dtrkyz[2];
                dgvrk.Rows[recordnumber].Cells[3].Value = dtrkyz[3];
                dgvrk.Rows[recordnumber].Cells[4].Value = dtrkyz[4];
                dgvrk.Rows[recordnumber].Cells[5].Value = dtrkyz[5];
                //设置按钮上的文字
                dgvrk.Rows[recordnumber].Cells[6].Value = "确定";
                dgvrk.Rows[recordnumber].Cells[7].Value = "退货";
                dgvrk.Rows[recordnumber].Cells[8].Value = dtrkyz[6];

                //DataGridView的行由变量控制，下移到下一行
                recordnumber++;
            }
            db.close();
            //SqlDataReader的读取只能在数据库连接状态下才能进行

        }
        public void dgvCellContentClickrk(rkb r)
        {
            db.AddParameters("@spm", SqlDbType.Char, r.spm);
            db.AddParameters("@xh", SqlDbType.Char, r.xh);
            db.AddParameters("@sl", SqlDbType.Char, r.sl);
            db.AddParameters("@rkr", SqlDbType.Char, r.rkr);
            db.AddParameters("@gys", SqlDbType.Char, r.gys);
            db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
            db.Update("update rkb set yz=0 where spm=@spm and xh=@xh and sl=@sl and rkr=@rkr and hjbh=@hjbh and yz=1");
        }

        public void dgvCellContentClickth(rkb r)
        {
            db.AddParameters("@spm", SqlDbType.NChar, r.spm);
            db.AddParameters("@xh", SqlDbType.Char, r.xh);
            db.AddParameters("@sl", SqlDbType.Char, r.sl);
            db.AddParameters("@rkr", SqlDbType.Char, r.rkr);
            db.AddParameters("@gys", SqlDbType.Char, r.gys);
            db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
            db.Update("update rkb set yz=-1 where spm=@spm and xh=@xh and sl=@sl and rkr=@rkr and hjbh=@hjbh and yz=1");
        }

        public void Updaterktj(rkb r)
        {
            db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
            db.AddParameters("@xh", SqlDbType.VarChar, r.xh);
            db.AddParameters("@sl", SqlDbType.Int, r.sl);
            db.Update("update spxxb set sl=sl+@sl where spbh=@spbh and xh=@xh");
        }
        public void Insertrkhj(rkb r)
        {
            DataTable dthj = new DataTable();
            db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
            db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
            db.AddParameters("@xh", SqlDbType.VarChar, r.xh);
            db.AddParameters("@sl", SqlDbType.Int, r.sl);
            dthj = db.Select("select * from hjxxb where hjbh=@hjbh and spbh=@spbh and xh=@xh");
            if (dthj.Rows.Count == 1)
            {
                db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
                db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
                db.AddParameters("@xh", SqlDbType.VarChar, r.xh);
                db.AddParameters("@sl", SqlDbType.Int, r.sl);
                db.Update("update hjxxb set sl=sl+@sl where hjbh=@hjbh and spbh=@spbh and xh=@xh");
            }
            else
            {
                db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
                db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
                db.AddParameters("@xh", SqlDbType.VarChar, r.xh);
                db.AddParameters("@sl", SqlDbType.Int, r.sl);
                db.Insert("insert into hjxxb (hjbh,spbh,xh,sl) values (@hjbh,@spbh,@xh,@sl)");
            }
        }


    }
}
