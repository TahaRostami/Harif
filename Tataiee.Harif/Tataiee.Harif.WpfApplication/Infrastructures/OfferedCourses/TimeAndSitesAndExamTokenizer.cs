using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.Infrastructures.OfferedCourses
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeAndSitesAndExamTokenizer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<string> Tokenize(string source)
        {
            List<string> tokens = new List<string>();
            char[] chars = source.ToCharArray();

            int i = 0;
            while (i < chars.Length)
            {
                if (chars[i] == 'م' && (i + 1 < chars.Length && chars[i + 1] == 'ک') && (i + 2 < chars.Length && chars[i + 2] == 'ا') && (i + 3 < chars.Length && chars[i + 3] == 'ن'))
                {
                    tokens.Add("مکان");
                    i += 3;
                    if (chars[i + 1] == ':')
                    {
                        tokens.Add(":");
                        i += 1;

                        i += 1;
                        string tok = "";
                        while (i < chars.Length && chars[i] != '#')
                        {
                            tok += chars[i].ToString();
                            i++;
                        }
                        tokens.Add(tok);
                        if (i < chars.Length && chars[i] == '#')
                            tokens.Add("#");

                    }
                }
                else if (chars[i] == 'د' && (i + 1 < chars.Length && chars[i + 1] == 'ر') && (i + 2 < chars.Length && chars[i + 2] == 'س'))
                {
                    tokens.Add("درس");
                    i += 2;
                }
                else if (chars[i] == 'ش' && (i + 1 < chars.Length && chars[i + 1] == 'ن') && (i + 2 < chars.Length && chars[i + 2] == 'ب')
                    && (i + 3 < chars.Length && chars[i + 3] == 'ه'))
                {
                    tokens.Add("شنبه");
                    i += 3;
                }
                else if (chars[i] == 'ي' && (i + 1 < chars.Length && chars[i + 1] == 'ك') && (i + 2 < chars.Length && chars[i + 2] == ' ')
                    && (i + 3 < chars.Length && chars[i + 3] == 'ش') && (i + 4 < chars.Length && chars[i + 4] == 'ن') && (i + 5 < chars.Length && chars[i + 5] == 'ب') && (i + 6 < chars.Length && chars[i + 6] == 'ه'))
                {
                    tokens.Add("یک شنبه");
                    i += 6;
                }
                else if (chars[i] == 'د' && (i + 1 < chars.Length && chars[i + 1] == 'و') && (i + 2 < chars.Length && chars[i + 2] == ' ')
                        && (i + 3 < chars.Length && chars[i + 3] == 'ش') && (i + 4 < chars.Length && chars[i + 4] == 'ن') && (i + 5 < chars.Length && chars[i + 5] == 'ب') && (i + 6 < chars.Length && chars[i + 6] == 'ه'))
                {
                    tokens.Add("دو شنبه");
                    i += 6;
                }
                else if (chars[i] == 'س' && (i + 1 < chars.Length && chars[i + 1] == 'ه') && (i + 2 < chars.Length && chars[i + 2] == ' ')
        && (i + 3 < chars.Length && chars[i + 3] == 'ش') && (i + 4 < chars.Length && chars[i + 4] == 'ن') && (i + 5 < chars.Length && chars[i + 5] == 'ب') && (i + 6 < chars.Length && chars[i + 6] == 'ه'))
                {
                    tokens.Add("سه شنبه");
                    i += 6;
                }
                else if (chars[i] == 'چ' && (i + 1 < chars.Length && chars[i + 1] == 'ه') && (i + 2 < chars.Length && chars[i + 2] == 'ا') &&
                    (i + 3 < chars.Length && chars[i + 3] == 'ر') && (i + 4 < chars.Length && chars[i + 4] == ' ') &&
                    (i + 5 < chars.Length && chars[i + 5] == 'ش') && (i + 6 < chars.Length && chars[i + 6] == 'ن') &&
                    (i + 7 < chars.Length && chars[i + 7] == 'ب') && (i + 8 < chars.Length && chars[i + 8] == 'ه'))
                {
                    tokens.Add("چهار شنبه");
                    i += 8;
                }
                else if (chars[i] == 'پ' && (i + 1 < chars.Length && chars[i + 1] == 'ن') && (i + 2 < chars.Length && chars[i + 2] == 'ج') &&
    (i + 3 < chars.Length && chars[i + 3] == ' ') && (i + 4 < chars.Length && chars[i + 4] == 'ش') &&
    (i + 5 < chars.Length && chars[i + 5] == 'ن') && (i + 6 < chars.Length && chars[i + 6] == 'ب') &&
    (i + 7 < chars.Length && chars[i + 5] == 'ه'))
                {
                    tokens.Add("پنج شنبه");
                    i += 7;
                }
                else if (chars[i] == 'ج' && (i + 1 < chars.Length && chars[i + 1] == 'م') && (i + 2 < chars.Length && chars[i + 2] == 'ع')
    && (i + 3 < chars.Length && chars[i + 3] == 'ه'))
                {
                    tokens.Add("جمعه");
                    i += 3;
                }
                else if (chars[i] == 'ا' && (i + 1 < chars.Length && chars[i + 1] == 'م') && (i + 2 < chars.Length && chars[i + 2] == 'ت')
                    && (i + 3 < chars.Length && chars[i + 3] == 'ح') && (i + 4 < chars.Length && chars[i + 4] == 'ا') && (i + 5 < chars.Length && chars[i + 5] == 'ن'))
                {
                    tokens.Add("امتحان");
                    i += 5;
                }
                else if (chars[i] == 'س' && (i + 1 < chars.Length && chars[i + 1] == 'ا') && (i + 2 < chars.Length && chars[i + 2] == 'ع') && (i + 3 < chars.Length && chars[i + 3] == 'ت'))
                {
                    tokens.Add("ساعت");
                    i += 3;
                }
                else if (chars[i] == '(')//open
                {
                    tokens.Add("(");
                }
                else if (chars[i] == ')')//close
                {
                    tokens.Add(")");
                }
                else if (chars[i] == 'ع' || chars[i] == 'ت')
                {
                    if (i - 1 > 0 && i + 1 < chars.Length && chars[i - 1] == '(' && chars[i + 1] == ')')
                    {
                        tokens.Add(chars[i].ToString());
                    }
                }
                else if (chars[i] == ':')
                {
                    tokens.Add(chars[i].ToString());
                }
                else if (chars[i] == '-')
                {
                    tokens.Add(chars[i].ToString());
                }
                else if (chars[i] == '.')
                {
                    tokens.Add(chars[i].ToString());
                }
                else if (chars[i] == '#')//new line
                {
                    tokens.Add("#");
                }
                else if (chars[i] > 47 && chars[i] < 58 && i + 1 < chars.Length && chars[i + 1] > 47 && chars[i + 1] < 58)
                {
                    if (i + 2 < chars.Length && chars[i + 2] > 47 && chars[i + 2] < 58 && i + 3 < chars.Length && chars[i + 3] > 47 && chars[i + 3] < 58)
                    {
                        tokens.Add(chars[i].ToString() + chars[i + 1].ToString() + chars[i + 2].ToString() + chars[i + 3].ToString());
                        i += 3;
                    }
                    else
                    {
                        tokens.Add(chars[i].ToString() + chars[i + 1].ToString());
                        i += 1;
                    }

                }
                else if (chars[i] == ' ')
                {

                }
                else
                {

                }
                i++;

            }
            tokens.Add("$");

            return tokens;
        }
    }
}
