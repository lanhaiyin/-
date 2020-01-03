using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dal;
using model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bll
{
    public class Classsplr
    {
        sjk sjk = new sjk();
        public int lr(spxx l,DataGridView dg,int row)
        {
            DataTable tcdx = new DataTable();
            DataTable tcdx2 = new DataTable();
            DataTable tcdx3 = new DataTable();
            tcdx=sjk.Select("select*from spb");
            tcdx2 = sjk.Select("select*from spxxb");
            for (int i = 0; i < tcdx.Rows.Count; i++)
            {
                if (tcdx.Rows[i]["spm"].ToString() == l.spm)
                {
                    for (int j = 0; j < tcdx2.Rows.Count; j++)
                    {
                        l.spbh=int.Parse(tcdx.Rows[i]["spbh"].ToString());
                        if (l.spbh==int.Parse(tcdx2.Rows[j]["spbh"].ToString())&&tcdx2.Rows[j]["xh"].ToString() == l.xh)
                        {
                            MessageBox.Show("已经有此型号无需输入！");
                            dg.Rows.Add();
                            dg.Rows[row].Cells[0].Value= l.spm;
                            dg.Rows[row].Cells[1].Value = l.xh;
                            dg.Rows[row].Cells[2].Value = "失败";
                            row++;
                            return row;
                        }
                    }
                    l.spbh = int.Parse(tcdx.Rows[i]["spbh"].ToString());
                    sjk.AddParameters("@spbh", SqlDbType.Int,l.spbh);
                     sjk.AddParameters("@xh", SqlDbType.VarChar, l.xh); 
                    sjk.Insert("insert into spxxb(spbh,xh,sl,zt) values(@spbh,@xh,0,1)");
                    MessageBox.Show("插入成功！");
                    dg.Rows.Add();
                    dg.Rows[row].Cells[0].Value = l.spm;
                    dg.Rows[row].Cells[1].Value = l.xh;
                    dg.Rows[row].Cells[2].Value = "成功";
                    row++;
                    return row;
                }   
            }
            sjk.AddParameters("@spm", SqlDbType.NChar, l.spm);
            sjk.Insert("insert into spb(spm,zt) values(@spm,1)");
            tcdx3 = sjk.Select("select*from spb");
            l.spbh = int.Parse(tcdx3.Rows[tcdx.Rows.Count]["spbh"].ToString());
            sjk.AddParameters("@spbh", SqlDbType.Int, l.spbh);
            sjk.AddParameters("@xh", SqlDbType.VarChar, l.xh);
            sjk.Insert("insert into spxxb(spbh,xh,sl,zt) values(@spbh,@xh,0,1)");
            MessageBox.Show("插入成功！");
            dg.Rows.Add();
            dg.Rows[row].Cells[0].Value = l.spm;
            dg.Rows[row].Cells[1].Value = l.xh;
            dg.Rows[row].Cells[2].Value = "成功";
            row++;
            return row;
        }

    }
}
