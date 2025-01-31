using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv3
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperCaseChars(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for(int i=0; i < Word.Length; i++)
                {
                    if (char.IsUpper(Word[i]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public static int GetCountOfLowerCaseChars(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
