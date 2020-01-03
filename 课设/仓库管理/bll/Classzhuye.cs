using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bll
{
    public class Classzhuye
    {
        public void a(Form fr)
        {
            fr.Top = 0;
            fr.Left = 0;
        }
        public void b(Form fr)
        {
            foreach (Form f in fr.MdiChildren)
            {
                if(!f.IsDisposed)
                f.Close(); ;
            }
        }
    }
}
