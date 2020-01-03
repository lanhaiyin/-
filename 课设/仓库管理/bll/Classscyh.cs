using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using dal;

namespace bll
{
    public class Classscyh
    {
        sjk db = new sjk();
        SqlDataReader dt;
        int row;
        public void cr(DataGridView dg)
        {
            dt = db.Select2("SELECT * FROM glyb");
            //从SqlDataReader对象中读取记录的方法
            while (dt.Read())//每次读取一行，记录会自动下移至下一条记录，反复读取，直到读完记录
            {
                dg.Rows.Add();//在DataGridView控件中添加一行
                //读取当前SqlDataReader对象中记录内容，将内容送到DataGridView指定记录和字段（行和列）中显示
                dg.Rows[row].Cells[0].Value = dt[0];
                dg.Rows[row].Cells[1].Value = dt[2];
                dg.Rows[row].Cells[2].Value = dt[3];
                //设置按钮上的文字
                dg.Rows[row].Cells[3].Value = "删除";
                //DataGridView的行由变量控制，下移到下一行
                row++;
            }
            db.close();
            //SqlDataReader的读取只能在数据库连接状态下才能进行
        }
        public void sc(string zh,int sum,DataGridView dg)
        {
            db.AddParameters("@zh", SqlDbType.VarChar, zh);
            db.Up("update glyb set zt=0 where glyzh=@zh");
            MessageBox.Show("用户删除成功！");
            dg.Rows.RemoveAt(sum);
        }
    }
}
