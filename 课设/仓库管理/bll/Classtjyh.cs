using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using model;
using dal;

namespace bll
{
    public class Classtjyh
    {
        sjk sjk = new sjk();
        public int tj(dl dl,int row,DataGridView dg)
        {
            DataTable tcdx = new DataTable();
            tcdx=sjk.Select("select * from glyb");
            for (int i = 0; i < tcdx.Rows.Count; i++)
            {
                if (tcdx.Rows[i][0].ToString() == dl.zh)
                {
                    MessageBox.Show("帐号已被使用，请重新输入！");
                    dg.Rows.Add();
                    dg.Rows[row].Cells[0].Value= dl.zh;
                    dg.Rows[row].Cells[1].Value = dl.mm;
                    dg.Rows[row].Cells[2].Value = dl.xm;
                    dg.Rows[row].Cells[3].Value = dl.qx;
                    dg.Rows[row].Cells[4].Value = "失败";
                    row++;
                    return row;
                }
            }
            
            sjk.AddParameters("@glyzh", SqlDbType.VarChar, dl.zh);
            sjk.AddParameters("@glymm", SqlDbType.VarChar, dl.mm);
            sjk.AddParameters("@glyxm", SqlDbType.VarChar, dl.xm);
            sjk.AddParameters("@glyqx", SqlDbType.Int, dl.qx);
            sjk.Insert("insert into glyb values(@glyzh,@glymm,@glyxm,@glyqx,1)");
            MessageBox.Show("帐号添加成功！");
            dg.Rows.Add();
            dg.Rows[row].Cells[0].Value = dl.zh;
            dg.Rows[row].Cells[1].Value = dl.mm;
            dg.Rows[row].Cells[2].Value = dl.xm;
            dg.Rows[row].Cells[3].Value = dl.qx;
            dg.Rows[row].Cells[4].Value = "成功";
            row++;
            return row;
            
        }
    }
}
