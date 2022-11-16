using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MaterialMES2ERP
{ 
    public class HexTransformatUtil
    {
        static String hexDigith = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        HexTransformatUtil() { }

        public static String hex10ToAnly(long num)
        {
            StringBuilder str = new StringBuilder();
            int Base = hexDigith.Trim().Length;
            if (0L == num)
            {
                str.Append(hexDigith[0]);
            }
            else
            {
                Stack s;
                for (s = new Stack(); num != 0L; num /= (long)Base)
                {
                    s.Push(hexDigith[(int)(num % (long)Base)]);
                }
                while (s.Count != 0)
                {
                    str.Append(s.Pop());
                }
            }

            String prefix = "";
            String suffix = str.ToString();
            return prefix + suffix;
        }

        public static int hexAnlyTo10(String hexValue)
        {
            if (null != hexValue && !("".Equals(hexValue.Trim())))
            {
                int Base = hexDigith.Trim().Length;
                Dictionary<string, int> digthMap = new Dictionary<string, int>();
                int count = 0;
                char[] var4 = hexDigith.Trim().ToCharArray();
                int sum = var4.Length;

                int index;
                for (index = 0; index < sum; ++index)
                {
                    char item = var4[index];
                    digthMap["" + item] = count;
                    ++count;
                }
                StringBuilder sb = new StringBuilder(hexValue.Trim());
                for (int i = 0; i < sb.Length / 2; i++)
                {
                    var temp = sb[sb.Length - i - 1];
                    sb[sb.Length - i - 1] = sb[i];
                    sb[i] = temp;
                }
                String str = sb.ToString();
                sum = 0;

                for (index = 0; index < str.Length; ++index)
                {
                    sum += (int)(Math.Pow((double)Base, (double)index)) * (int)digthMap["" + str[index]];
                }

                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}
