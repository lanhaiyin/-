using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using dal;
namespace bll
{
    public class Classhjqk
    {
        sjk sjk = new sjk();
        banding bd = new banding();
        public void bh(ComboBox com)
        {
            DataTable dt = new DataTable();
            dt = sjk.Select("select * from hjb");
            bd.bd(com,dt,"hjbh","hjbh");
        }
        public void cx(DataGridView dg, string bh)
        {
            DataTable dt = new DataTable();
            sjk.AddParameters("@hjbh",SqlDbType.VarChar,bh);
            dt = sjk.Select("SELECT hjbh AS 货架编号, spbh AS 商品编号, xh AS 规格, sl AS 数量 FROM dbo.hjxxb");
            dg.DataSource = dt;
        }
    }
}
