using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearn.Data
{
    class InformationAboutWord
    {
        static public char [] GetMassiveLetter( string word)
        {
            char [] words = word.ToCharArray();

            return words;

        }

        static public int CountLetter(string word)
        {
            return word.Count();
        }
    }
}
