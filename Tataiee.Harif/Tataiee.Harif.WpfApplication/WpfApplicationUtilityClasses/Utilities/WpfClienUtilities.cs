using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Utilities
{
    public static class WpfClienUtilities
    {
        public static string ChangeFarsiNumberInStringToEnglishNumber(this string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch(str[i])
                {
                    case '۰':
                        res += "0";
                        break;
                    case '۱':
                        res += "1";
                        break;
                    case '۲':
                        res += "2";
                        break;
                    case '۳':
                        res += "3";
                        break;
                    case '۴':
                        res += "4";
                        break;
                    case '۵':
                        res += "5";
                        break;
                    case '۶':
                        res += "6";
                        break;
                    case '۷':
                        res += "7";
                        break;
                    case '۸':
                        res += "8";
                        break;
                    case '۹':
                        res += "9";
                        break;
                    default:
                        res += str[i];
                        break;
                }
            }
            return res;
        }
    }
}
