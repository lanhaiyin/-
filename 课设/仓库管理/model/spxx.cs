using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class spxx
    {
        private int intid;
        private int intspbh;
        private string strxh;
        private int intsl;
        private string inspm;
        private int inrow;
        public int row
        {
            get { return inrow; }
            set { inrow = value; }
        }
        public int id
        {
            get { return intid; }
            set { intid = value; }
        }
        public int spbh
        {
            get { return intspbh; }
            set { intspbh = value; }
        }
        public string xh
        {
            get { return strxh; }
            set { strxh = value; }
        }
        public int sl
        {
            get { return intsl; }
            set { intsl = value; }
        }
        public string spm
        {
            get { return inspm; }
            set { inspm = value; }
        }
    }
}
