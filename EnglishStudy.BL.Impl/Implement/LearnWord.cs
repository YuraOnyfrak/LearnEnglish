using EnglishTeachcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace EnglishLearn.BL.Abstract.Abstract
{
    class LearnWord
    {
        Dictionary<string, Words> learnWord = new Dictionary<string, Words>();
        int count = 1;        
        private bool TurnOf = true;

        

        private string LearnWords(KeyValuePair<string, Words> item, Image picture, TextBox lbUkrWord, TextBox lbEnglWord, TextBox lbTranckWord)
        {
            string resurce = item.Key.ToString();

            AddPicture(resurce, picture);

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    lbUkrWord.Text = item.Value.WordUkr.ToString();
                }
                else if (i == 1)
                {
                    lbEnglWord.Text = item.Value.WordEngl;
                    // VoiceText();

                }
                else
                {
                    lbTranckWord.Text = item.Value.WordTranscription;
                }

            }

            return resurce;
        }

        private void AddPicture(string path, Image image)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(path);
            logo.EndInit();
            image.Source = logo;
        }

        public void NextWordLearn(Image picture, TextBox lbUkrWord, TextBox lbEnglWord, TextBox lbTranckWord)
        {

            if (count < learnWord.Count)
            {
                LearnWords(learnWord.ElementAt(count), picture, lbUkrWord, lbEnglWord, lbTranckWord);
                count++;
            }

        }

        public void LearnFirstWords(Image picture ,TextBox lbUkrWord, TextBox lbEnglWord, TextBox lbTranckWord)
        {
            learnWord.Add(@"D:\\1.jpg", new Words("будинок1", "tought", "[h o m e1]"));
            learnWord.Add(@"D:\\2.jpg", new Words("будинок", "home", "[h o m e]"));
            learnWord.Add(@"D:\\3.jpg", new Words("будинок1", "cat", "[ c a t ]"));
            learnWord.Add(@"D:\\4.jpg", new Words("будинок1", "human", "[ c a t ]"));

            // AddPicture(PATHVoiceTrue, Sound);


            foreach (var item in learnWord)
            {
                LearnWords(learnWord.First(), picture,  lbUkrWord, lbEnglWord, lbTranckWord);

            }

        }

        
    }
}
