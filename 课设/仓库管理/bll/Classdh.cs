using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dal;
using System.Windows.Forms;
using System.Data;

namespace bll
{
    public class Classdh
    {
        sjk sjk = new sjk();
        banding bd = new banding();
        public void bh(ComboBox com,string a,string b,string c)
        {
            DataTable tc = new DataTable();
            tc = sjk.Select(a);
            bd.bd(com,tc,b,c);
        }
        public void dhcx(DataGridView dg,int dh,string cx,string bl)
        {
            DataTable dt=new DataTable();
            sjk.AddParameters(bl,SqlDbType.Int,dh);
            dt = sjk.Select(cx);
            dg.DataSource = dt;
        }
    }
}
