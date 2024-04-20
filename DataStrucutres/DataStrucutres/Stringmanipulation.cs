using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    public static class Stringmanipulation
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            HashSet<int> myset = new HashSet<int>();
            HashSet<int> myset2 = new HashSet<int>();
            int k = 0;
            int j = 0;
            while (k != s.Length && j != t.Length)
            {
                Console.WriteLine($"K={k} and J={j}");
                if (s[k] == t[j])
                {
                    if (myset2.Contains(j))
                    {
                        continue;
                    }
                    else
                    {
                        myset.Add(k);
                        myset2.Add(j);
                        j = -1;
                        k++;
                    }
                }
                j++;
            }
            if (myset2.Count == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
   
}
