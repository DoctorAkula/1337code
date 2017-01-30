using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class StringReverse
    {
        private char[] content;

        public string ReverseString(string s)
        {
            char[] sa = s.ToCharArray();
            char[] he = new char[sa.Length];
            
            for(int i = sa.Length - 1, j = 0; i >= 0; i--,j++)
            {
                he[j] = sa[i];
            }
            return new string(he);
        }
/*
        public string ReverseString(string s)
        {
            char[] sa = s.ToCharArray();
            StringBuilder he = new StringBuilder();

            for (int i = sa.Length - 1, j = 0; i >= 0; i--, j++)
            {
                he.Append(sa[i]);
            }
            return he.ToString();
        }
*/
    }
}

/*
     01234
    "hello"  (length = 5)

            i               sa[i]
    1       i = 4           o
    2       i = 3


 */

