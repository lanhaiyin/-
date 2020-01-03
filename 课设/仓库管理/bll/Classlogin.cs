using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using model;
using dal;

namespace bll
{
    public class Classlogin
    {
        sjk sjk = new sjk();
        DataTable tcdx = new DataTable();
        public void dlz(Form fr,Form zhuye,dl dl)
        {
            tcdx=sjk.Select("select*from glyb");
            for (int i = 0; i < tcdx.Rows.Count; i++)
            {
                if (tcdx.Rows[i]["glyzh"].ToString() == dl.zh)
                {

                    if (tcdx.Rows[i]["glymm"].ToString() != dl.mm)
                    {
                        MessageBox.Show("密码错误！");
                        return;
                    }
                    dlshuju.dlzh = dl.zh;
                    dlshuju.dlmm = dl.mm;
                    dlshuju.qx = int.Parse(tcdx.Rows[i]["qx"].ToString());
                    zhuye.Show();
                    fr.Hide();
                    return;
                }
            }
            MessageBox.Show("帐号错误！");
            return;
        }
    }
}
