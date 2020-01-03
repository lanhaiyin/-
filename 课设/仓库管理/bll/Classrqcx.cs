using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using dal;

namespace bll
{
    public class Classrqcx
    {
        sjk sjk = new sjk();
        public void cx(DataGridView dg,DataGridView  dg2,System.DateTime datetime)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sjk.AddParameters("@sj", SqlDbType.SmallDateTime, datetime);
            sjk.AddParameters("@sj2", SqlDbType.SmallDateTime, datetime.AddDays(1));
            dt = sjk.Select("select * from rkdh where rksj>@sj and rksj<@sj2");
            sjk.AddParameters("@sj", SqlDbType.SmallDateTime, datetime);
            sjk.AddParameters("@sj2", SqlDbType.SmallDateTime, datetime.AddDays(1));
            dt2 = sjk.Select("select * from ckdh where cksj>@sj and cksj<@sj2");
            dg.DataSource = dt;
            dg2.DataSource = dt2;

        }
    }
}
