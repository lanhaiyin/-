using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using dal;
using model;

namespace bll
{
    public class Classxgmm
    {
        sjk sjk = new sjk();
        public void tj(mm mm, Form t)
        {
            if (mm.ymm != dlshuju.dlmm)
            {
                MessageBox.Show("原密码错误，不能进行修改！");
                return;
            }
            sjk.AddParameters("@glymm", SqlDbType.NVarChar, mm.xmm);
            sjk.AddParameters("@glyzh", SqlDbType.NVarChar, dlshuju.dlzh);
            sjk.Update("update Login set glymm=@glymm where glyzh=@glyzh");
            MessageBox.Show("密码修改成功，请重新登录！");
            t.Hide();
            dlshuju.fr.Hide();
            dlshuju.fr2.Show();
        }
    }
}
