using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace bll
{
    public class Validator
    {
        public Boolean Ishjbh(string str)
        {
            Regex regexS = new Regex(@"^[A-Z][0-9]{1,2}$");
            return regexS.IsMatch(str);
        }
        public Boolean Ishjck(string str)
        {
            Regex regexS = new Regex(@"^[0-9]{3,5}$");
            return regexS.IsMatch(str);
        }
        public Boolean Isspm(string str)
        {
            Regex regexS = new Regex(@"^[\u4e00-\u9fbb]{2,}$");
            return regexS.IsMatch(str);
        }
        public bool Isxh1(string str)
        {
            Regex reg = new Regex(@"^[\u4e00-\u9fbb]{1,}[a-zA-Z0-9]{1,}$");
            return reg.IsMatch(str);
        }
        public bool Isxh3(string str)
        {
            Regex reg = new Regex(@"^[\u4e00-\u9fbb]{1,}$");
            return reg.IsMatch(str);
        }
        public bool Isuid(string str)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]{3,}$");
            return reg.IsMatch(str);
        }
        public bool IsPassword(string str)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]{3,}$");
            return reg.IsMatch(str);
        }
        public bool IsNumber(string str)
        {
            Regex reg = new Regex(@"^\d{1,8}$");
            return reg.IsMatch(str);
        }
        public bool Isqx(string str)
        {
            Regex reg = new Regex(@"^\[123]$");
            return reg.IsMatch(str);
        }
    }
}
