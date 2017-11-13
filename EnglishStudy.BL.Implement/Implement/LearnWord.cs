using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudy.BL.Implement.Implement
{
   public class LearnWord
    {        
        //private string LearnWords(KeyValuePair<string, Words> item, string picture, string lbUkrWord, string lbEnglWord, string lbTranckWord)
        //{
        //    string resurce = item.Key.ToString();
            
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (i == 0)
        //        {
        //            lbUkrWord.Text = item.Value.WordUkr.ToString();
        //        }
        //        else if (i == 1)
        //        {
        //            lbEnglWord.Text = item.Value.WordEngl;
        //            // VoiceText();

        //        }
        //        else
        //        {
        //            lbTranckWord.Text = item.Value.WordTranscription;
        //        }

        //    }

        //    return resurce;
        //}
        
        //public void NextWordLearn(Image picture, string lbUkrWord, string lbEnglWord, string lbTranckWord)
        //{

        //    if (count < learnWord.Count)
        //    {
        //        LearnWords(learnWord.ElementAt(count), picture, lbUkrWord, lbEnglWord, lbTranckWord);
        //        count++;
        //    }

        //}

        public static void LearnFirstWords(Dictionary<string, Word> dictionary, ref string pictureSource, ref  string ukrWord, ref  string englWord,  ref string tranckWord)
        {
           var firstItemp = dictionary.Values.First();

           pictureSource = dictionary.Keys.First();
           ukrWord = firstItemp.WordUkr;
           englWord = firstItemp.WordEngl;
           tranckWord = firstItemp.WordTranscription;

        }
    }
}
