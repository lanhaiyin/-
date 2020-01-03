using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dal;
using model;
using System.Data;
using System.Windows.Forms;

namespace bll
{
    public class Classrktj
    {
        sjk db = new sjk();
        DataTable dtspm = new DataTable();
        DataTable dtxh = new DataTable();
        DataTable dthj = new DataTable();
        banding bd = new banding();
        public void DataBindingCmbSpm(ComboBox cmbspm)
        {
            //组合框的绑定
            dtspm = db.Select("select spbh,spm from spb");
            bd.bd(cmbspm, dtspm, "spm", "spbh");
        }
        public void DataBindingCmbSpxh(ComboBox cmbspxh, rkb r)
        {
            //组合框的绑定
            db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
            dtspm = db.Select("select spbh,xh from spxxb where spbh=@spbh");
            bd.bd(cmbspxh, dtspm, "xh", "xh");
        }
        public void DataBindingCmbgys(ComboBox cmbgys)
        {
            //组合框的绑定
            dtspm = db.Select("select gysbh,gys from gysb");
            bd.bd(cmbgys, dtspm, "gys", "gysbh");
        }
        public void DataBindingCmbcfhj(ComboBox cmbcfhj)
        {
            //组合框的绑定
            dtspm = db.Select("select hjbh from hjb");
            bd.bd(cmbcfhj, dtspm, "hjbh", "hjbh");
        }
        public void Insertrktj(rkb r)
        {
            db.AddParameters("@spbh", SqlDbType.Int, r.spbh);
            db.AddParameters("@spm", SqlDbType.Char, r.spm);
            db.AddParameters("@xh", SqlDbType.VarChar, r.xh);
            db.AddParameters("@sl", SqlDbType.Int, r.sl);
            db.AddParameters("@rkr", SqlDbType.VarChar, r.rkr);
            db.AddParameters("@gysbh", SqlDbType.Int, r.gysbh);
            db.AddParameters("@hjbh", SqlDbType.Char, r.cfhj);
            db.Insert("insert into rkb (spbh,spm,xh,sl,rkr,gysbh,hjbh,rksj,yz)values(@spbh,@spm,@xh,@sl,@rkr,@gysbh,@hjbh,GETDATE(),1)");
        }
        
        public void DataBindingDataGridView(DataGridView dgvrk,int num,rkb r,gysb g)
        {
            dgvrk.Rows.Add();
            dgvrk.Rows[num].Cells[0].Value = r.spm;
            dgvrk.Rows[num].Cells[1].Value = r.xh;
            dgvrk.Rows[num].Cells[2].Value = r.sl;
            dgvrk.Rows[num].Cells[3].Value = g.gys;
            dgvrk.Rows[num].Cells[4].Value = r.cfhj;
        }
    }
}
