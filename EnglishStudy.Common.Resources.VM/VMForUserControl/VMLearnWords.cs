using EnglishStudy.BL.Implement.Implement;
using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.Base;
using EnglishStudy.Entity.Abstract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
    public class VMLearnWords : ViewModelBase
    {
        Data _data;

        private string _ukrWord;

        private string _englWord;

        private string _tranckWord;

        private int _index;

        private string _sourseImage;

        private IMainWindowsCodeBehind _codeBehind;

        public string UkrWord
        {
            get { return _ukrWord; }
            set
            {
                _ukrWord = value;
                OnPropertyChanged("UkrWord");
            }
        }

        public string EnglWord
        {
            get { return _englWord; }
            set
            {
                _englWord = value;
                OnPropertyChanged("EnglWord");
            }
        }

        public string TranckWord
        {
            get { return _tranckWord; }
            set
            {
                _tranckWord = value;
                OnPropertyChanged("TranckWord");
            }
        }

        public string SourseImage
        {
            get { return _sourseImage; }
            set
            {
                _sourseImage = value;
                OnPropertyChanged("SourseImage");
            }
        }        

        public ICommand NextWordCommand
        {
            get
            {
                return new RelayCommand(x => this.NextWord());
            }
        }

        private void NextWord()
        {
            if (_index < 6)
            {
                var _currentItem = _data.GetDictionary.ElementAt(_index);
                EnglWord = _currentItem.Value.WordEngl;
                UkrWord = _currentItem.Value.WordUkr;
                TranckWord = _currentItem.Value.WordTranscription;
                SourseImage = _currentItem.Key;
                _index++;
                
            }
            else
            {
                _codeBehind.LoadView(ViewType.TestWords);
            }
        }

        public VMLearnWords(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
            _data = new Data();

            LearnWord.LearnFirstWords(_data.GetDictionary,ref _sourseImage, ref _ukrWord, ref _englWord, ref _tranckWord );
        }
    }
}
