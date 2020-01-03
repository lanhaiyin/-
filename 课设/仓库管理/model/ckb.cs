using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class ckb
    {
        private int intckbh;
        private int intspbh;
        private string strspm;
        private string strxh;
        private int intsl;
        private string strcfhj;
        private string strchr;
        private string strshr;
        private DateTime dtmcksj;
        private int intyz;

        public int ckbh
        {
            get { return intckbh; }
            set { intckbh = value; }
        }
        public int spbh
        {
            get { return intspbh; }
            set { intspbh = value; }
        }
        public string spm
        {
            get { return strspm; }
            set { strspm = value; }
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
        public string cfhj
        {
            get { return strcfhj; }
            set { strcfhj = value; }
        }
        public string chr
        {
            get { return strchr; }
            set { strchr = value; }
        }
        public string shr
        {
            get { return strshr; }
            set { strshr = value; }
        }
        public DateTime cksj
        {
            get { return dtmcksj; }
            set { dtmcksj = value; }
        }
        public int yz
        {
            get { return intyz; }
            set { intyz = value; }
        }
    }
}
