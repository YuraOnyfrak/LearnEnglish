using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudy.BL.Implement.Implement
{
    public class Word
    {
        private string _wordEngl;

        private string _wordUkr;

        private string _wordTranscription;

        public string WordUkr
        {
            get { return _wordUkr; }
            private set { _wordUkr = value; } 
        }

        public string WordEngl
        {
            get { return _wordEngl; }
            private set { _wordEngl = value; }
        }

        public string WordTranscription
        {
            get { return _wordTranscription; }
            private set { _wordTranscription = value; }
        }

        public string Mark { get; set; }

        public string PathImage { get; set; }

        public static int[] MarksArray;

        public Word(string wordUkr, string wordEngl, string wordTranscription)
        {
            this._wordUkr = wordUkr;
            this._wordEngl = wordEngl;
            this._wordTranscription = wordTranscription;

        }

        public Word(string wordUkr, string wordEngl, string mark, string pathImage)
        {
            WordUkr = wordUkr;
            WordEngl = wordEngl;
            Mark = mark;
            PathImage = pathImage;
        }

        public static int CountWordForLearning = 6; 

        public static void Initialize()
        {
            MarksArray = new int[6];
            
            for (int i = 0; i < MarksArray.Length; i++)
            {
                MarksArray[i] = 0;
            }
        }
    }
}
