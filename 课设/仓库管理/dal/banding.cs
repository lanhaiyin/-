using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace dal
{
    public class banding
    {
        sjk db = new sjk();
        public void bd(ComboBox com,DataTable  tcdx,string b,string c)
        {
            com.DataSource = tcdx;
            com.DisplayMember = b;
            com.ValueMember = c;
        }
    }
}
