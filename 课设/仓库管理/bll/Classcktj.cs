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
    public class Classcktj
    {
        sjk db = new sjk();
        banding bd = new banding();
        SqlDataReader dtrksl;
        DataTable dtspm = new DataTable();
        DataTable dtxh = new DataTable();
        DataTable dtgys = new DataTable();
        DataTable dthj = new DataTable();
        public void DataBindingCmbckSpm(ComboBox cmbspm)
        {
            //组合框的绑定
            dtspm = db.Select("SELECT DISTINCT dbo.spxxb.spbh, dbo.spb.spm FROM dbo.spxxb INNER JOIN dbo.spb ON dbo.spxxb.spbh = dbo.spb.spbh WHERE (dbo.spxxb.sl > 0)");
            bd.bd(cmbspm,dtspm, "spm", "spbh");
        }

        public void DataBindingCmbckSpxh(ComboBox cmbxh, ckb c)
        {
            //组合框的绑定
            db.AddParameters("@spbh", SqlDbType.Int, c.spbh);
            dtxh = db.Select("select xh from hjxxb where spbh=@spbh and sl>0");
            bd.bd(cmbxh, dtxh, "xh", "xh");
        }

        public void DataBindingCmbckcfhj(ComboBox cmbcfhj,ckb c)
        {
            //组合框的绑定
            db.AddParameters("@spbh", SqlDbType.Int, c.spbh);
            db.AddParameters("@xh",SqlDbType.VarChar,c.xh);
            dthj = db.Select("select hjbh from hjxxb where spbh=@spbh and xh=@xh");
            bd.bd(cmbcfhj, dthj, "hjbh", "hjbh");
        } 

        public void DataBindingCmbckshr(ComboBox cmbshr)
        {
            //组合框的绑定
            dtgys = db.Select("SELECT khbh,kh from khb");
            bd.bd(cmbshr, dtgys, "kh", "khbh");
        }

        public void DataBindingCmbcksl(ckb c)
        {
            db.AddParameters("@spbh",SqlDbType.Int,c.spbh);
            db.AddParameters("@xh",SqlDbType.VarChar,c.xh);
            db.AddParameters("@hjbh", SqlDbType.VarChar, c.cfhj);
            dtrksl = db.Select2("select sl from hjxxb where hjbh=@hjbh and spbh=@spbh and xh=@xh");
            while (dtrksl.Read())//每次读取一行，记录会自动下移至下一条记录，反复读取，直到读完记录
            {
                c.sl = int.Parse(dtrksl[0].ToString());
            }
            db.close();
        }
        public void Insertrktj(ckb c)
        {
            db.AddParameters("@spbh", SqlDbType.Int, c.spbh);
            db.AddParameters("@spm", SqlDbType.Char, c.spm);
            db.AddParameters("@xh", SqlDbType.VarChar, c.xh);
            db.AddParameters("@sl", SqlDbType.Int, c.sl);
            db.AddParameters("@chr", SqlDbType.VarChar, c.chr);
            db.AddParameters("@shr", SqlDbType.Int, c.shr);
            db.AddParameters("@cfhj", SqlDbType.Char, c.cfhj);
            db.Insert("insert into ckb (spbh,spm,xh,sl,chr,shr,cfhj,cksj,yz)values(@spbh,@spm,@xh,@sl,@chr,@shr,@cfhj,GETDATE(),1)");
        }
        public void DataBindingDataGridView(DataGridView dgvck, int num, ckb c, khb k)
        {
            dgvck.Rows.Add();
            dgvck.Rows[num].Cells[0].Value = c.spm;
            dgvck.Rows[num].Cells[1].Value = c.xh;
            dgvck.Rows[num].Cells[2].Value = c.sl;
            dgvck.Rows[num].Cells[3].Value = c.cfhj;
            dgvck.Rows[num].Cells[4].Value = k.kh;
        }
    }
}
