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
    public class Classspkc
    {
        sjk sjk = new sjk();
        public DataTable cx(DataGridView dg)
        {
            SqlDataReader dt;     
            int row=0;
            DataTable tc = new DataTable();
            tc = sjk.Select("select * from spzl");
            dt = sjk.Select2("select * from spkc");
            //从SqlDataReader对象中读取记录的方法
            while (dt.Read())//每次读取一行，记录会自动下移至下一条记录，反复读取，直到读完记录
            {
                dg.Rows.Add();//在DataGridView控件中添加一行
                //读取当前SqlDataReader对象中记录内容，将内容送到DataGridView指定记录和字段（行和列）中显示
                dg.Rows[row].Cells[0].Value = dt[1];
                dg.Rows[row].Cells[1].Value = dt[2];
                dg.Rows[row].Cells[2].Value = dt[3];
                //设置按钮上的文字
                dg.Rows[row].Cells[3].Value = dt[4];
                //DataGridView的行由变量控制，下移到下一行
                row++;
            }
            sjk.close();
            return tc;
        }
    }
}
