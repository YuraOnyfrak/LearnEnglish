using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;

namespace EnglishStudy.BL.Implement.Implement
{
  public class BTransletor
    {

        Translator tr;
        const string transletorKey = "trnsl.1.1.20170628T093750Z.300966396241622b.9d5ca372d77b60d18d56cb56cdea3a3d9a190dc3";  //AIzaSyARnOG1hcHvRR8sVAM_rWv41fsFz7U_f54

        public BTransletor()
        {
            tr = new YandexLinguistics.NET.Translator(transletorKey);
        }

        public LangPair GetLangPair(string inputLang, string outputLang)
        {
            LangPair lp = new LangPair();

            switch (inputLang)
            {
                case "Украинский":
                    lp.InputLang = Lang.Uk;
                    break;

                case "Английский":
                    lp.InputLang = Lang.En;
                    break;


                default:
                    break;
            }

            switch (outputLang)
            {
                case "Украинский":
                    lp.OutputLang = Lang.Uk;
                    break;

                case "Английский":
                    lp.OutputLang = Lang.En;
                    break;


                default:
                    break;
            }

            return lp;

        }

        public string Translator(string wordToTranslate, LangPair langPair)
        {
            return tr.Translate(wordToTranslate, langPair).Text;
        }


     
    }
}
