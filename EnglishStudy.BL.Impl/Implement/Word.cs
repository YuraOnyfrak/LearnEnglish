using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTeachcher
{
    class Words
    {
        private string wordEngl;
        private string wordUkr;
        private string wordTranscription;
        
        public string WordUkr
        {
            get { return wordUkr; }
        }

        public string WordEngl
        {
            get { return wordEngl; }
        }

        public string WordTranscription
        {
            get { return wordTranscription; }
        }

        public Words(string wordUkr,string wordEngl, string wordTranscription)
        {
            this.wordUkr = wordUkr;
            this.wordEngl = wordEngl;
            this.wordTranscription = wordTranscription;

        }

        

    }
}
