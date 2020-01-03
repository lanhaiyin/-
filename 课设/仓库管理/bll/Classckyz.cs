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
    public class Classckyz
    {
        sjk db = new sjk();
        SqlDataReader dtckyz;
        int recordnumber;
        public void DataBindingDataGridViewckyz(DataGridView dgvck)
        {
            dtckyz = db.Select2("SELECT spm,xh,sl,cfhj,chr,shr,spbh,ckbh from ckb where yz=1");
            //从SqlDataReader对象中读取记录的方法
            while (dtckyz.Read())//每次读取一行，记录会自动下移至下一条记录，反复读取，直到读完记录
            {
                dgvck.Rows.Add();//在DataGridView控件中添加一行
                //读取当前SqlDataReader对象中记录内容，将内容送到DataGridView指定记录和字段（行和列）中显示
                dgvck.Rows[recordnumber].Cells[0].Value = dtckyz[0];
                dgvck.Rows[recordnumber].Cells[1].Value = dtckyz[1];
                dgvck.Rows[recordnumber].Cells[2].Value = dtckyz[2];
                dgvck.Rows[recordnumber].Cells[3].Value = dtckyz[3];
                dgvck.Rows[recordnumber].Cells[4].Value = dtckyz[4];
                dgvck.Rows[recordnumber].Cells[5].Value = dtckyz[5];
                //设置按钮上的文字
                dgvck.Rows[recordnumber].Cells[6].Value = "确定";
                dgvck.Rows[recordnumber].Cells[7].Value = "取消";
                dgvck.Rows[recordnumber].Cells[8].Value = dtckyz[6];
                dgvck.Rows[recordnumber].Cells[9].Value = dtckyz[7];
                //DataGridView的行由变量控制，下移到下一行
                recordnumber++;
            }
            db.close();
            //SqlDataReader的读取只能在数据库连接状态下才能进行

        }
        public void dgvCellContentClickth(ckb c)
        {

            db.AddParameters("@ckbh", SqlDbType.Int, c.ckbh);
            db.AddParameters("@spm", SqlDbType.NChar, c.spm);
            db.AddParameters("@xh", SqlDbType.Char, c.xh);
            db.AddParameters("@sl", SqlDbType.Char, c.sl);
            db.AddParameters("@chr", SqlDbType.Char, c.chr);
            db.AddParameters("@shr", SqlDbType.Char, c.shr);
            db.AddParameters("@cfhj", SqlDbType.Char, c.cfhj);
            db.Update("update ckb set yz=-1 where ckbh=@ckbh");
        }
        public int dgvCellContentClickrk(ckb c)
        {
            DataTable dt=new DataTable();
            db.AddParameters("@spm", SqlDbType.Char, c.spm);
            db.AddParameters("@xh", SqlDbType.Char, c.xh);
            db.AddParameters("@hjbh", SqlDbType.Char, c.cfhj);
            dt=db.Select("SELECT dbo.hjxxb.sl FROM dbo.hjxxb INNER JOIN dbo.spb ON dbo.hjxxb.spbh = dbo.spb.spbh where spm=@spm and xh=@xh and hjbh=@hjbh");
            if (int.Parse(dt.Rows[0]["sl"].ToString()) < c.sl)
            {
                MessageBox.Show("数量不足");
                return 1;
            }
            else
            {
                db.AddParameters("@ckbh", SqlDbType.Int, c.ckbh);
                db.AddParameters("@spm", SqlDbType.Char, c.spm);
                db.AddParameters("@xh", SqlDbType.Char, c.xh);
                db.AddParameters("@sl", SqlDbType.Char, c.sl);
                db.AddParameters("@chr", SqlDbType.Char, c.chr);
                db.AddParameters("@shr", SqlDbType.Char, c.shr);
                db.AddParameters("@cfhj", SqlDbType.Char, c.cfhj);
                db.Update("update ckb set yz=0 where ckbh=@ckbh");
                return 2;
            }
        }
        public void Updatecktj(ckb c)
        {
            db.AddParameters("@spbh", SqlDbType.Int, c.spbh);
            db.AddParameters("@xh", SqlDbType.VarChar, c.xh);
            db.AddParameters("@sl", SqlDbType.Int, c.sl);
            db.Update("update spxxb set sl=sl-@sl where spbh=@spbh and xh=@xh");
        }
        public void Insertckhj(ckb c)
        {
            DataTable dthj = new DataTable();
            db.AddParameters("@hjbh", SqlDbType.Char, c.cfhj);
            db.AddParameters("@spbh", SqlDbType.Int, c.spbh);
            db.AddParameters("@xh", SqlDbType.VarChar, c.xh);
            db.AddParameters("@sl", SqlDbType.Int, c.sl);
            db.Update("update hjxxb set sl=sl-@sl where hjbh=@hjbh and spbh=@spbh and xh=@xh");
        }
    }
}
