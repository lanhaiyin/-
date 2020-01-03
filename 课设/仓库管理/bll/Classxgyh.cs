using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using dal;
using model;

namespace bll
{
    public class Classxgyh
    {
        sjk db = new sjk();
        
        public void cr(DataGridView dg)
        {
            DataTable dt = new DataTable();
            dt = db.Select("SELECT * FROM glyb");
            dg.DataSource=dt;
            dg.Columns[4].Visible = false;
            //禁止排序
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dg.Columns[0].HeaderText = "管理员帐号";
            dg.Columns[1].HeaderText = "管理员密码";
            dg.Columns[2].HeaderText = "管理员姓名";
            dg.Columns[3].HeaderText = "权限";
            dg.Columns[4].Visible = false;

        }

        public void xg(dl dl,int sum,DataGridView dg)
        {
            bool t = true;
            DataTable dt = new DataTable();
            dt = db.Select("SELECT * FROM glyb where zt=1");
            db.AddParameters("@zh", SqlDbType.VarChar, dt.Rows[sum][0]);
            db.AddParameters("@glymm", SqlDbType.VarChar, dl.mm);
            db.AddParameters("@glyxm", SqlDbType.VarChar, dl.xm);
            db.AddParameters("@qx", SqlDbType.VarChar, dl.qx);
            db.AddParameters("@glyzh", SqlDbType.VarChar, dl.zh);
            t=db.Up("update glyb set glyzh=@glyzh  where glyzh=@zh");
            if (t == false)
            {
                MessageBox.Show("此帐号已存在，修改失败");
                db.clear();
                return;
            }
            db.Up("update glyb set glymm=@glymm  where glyzh=@glyzh");
            db.Up("update glyb set glyxm=@glyxm  where glyzh=@glyzh");
            db.Up("update glyb set qx=@qx  where glyzh=@glyzh");
            db.clear();
            MessageBox.Show("用户修改成功！");
        }
    }
}
