using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.Base;
using EnglishStudy.Common.UserControl.UserControl;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;
using System;
using EnglishStudy.BL.Implement.Implement;
using System.Linq;
using System.Windows;
using EnglishStudy.Entity.Abstract.Enum;

namespace EnglishLearn.Common.Resources.VM.VMForUserControl
{
    public class TestVM : ViewModelBase
    {

        #region field

        Data data = new Data();

        LearnWords learn = new LearnWords();

        private int _index = 1;

        private IMainWindowsCodeBehind _codeBehind;

        private string _versionOne;

        private string _versionTwo;

        private string _versionThree;

        private string _versionFour;

        private string _versionFive;

        private string _versionSix;

        private string _englishWord;

        private string _transcription;

        private string _resoursePhoto;

        #endregion

        #region property

        public string VersionOne
        {
            get { return _versionOne; }
            set
            {
                _versionOne = value;
                OnPropertyChanged("VersionOne");
            }
        }

        public string VersionTwo
        {
            get { return _versionTwo; }
            set
            {
                _versionTwo = value;
                OnPropertyChanged("VersionTwo");
            }
        }

        public string VersionThree
        {
            get { return _versionThree; }
            set
            {
                _versionThree = value;
                OnPropertyChanged("VersionThree");
            }
        }

        public string VersionFour
        {
            get { return _versionFour; }
            set
            {
                _versionFour = value;
                OnPropertyChanged("VersionFour");
            }
        }

        public string VersionFive
        {
            get { return _versionFive; }
            set
            {
                _versionFive = value;
                OnPropertyChanged("VersionFive");
            }
        }

        public string VersionSix
        {
            get { return _versionSix; }
            set
            {
                _versionSix = value;
                OnPropertyChanged("VersionSix");
            }
        }

        public string EnglishWord
        {
            get { return _englishWord; }
            set
            {
                _englishWord = value;
                OnPropertyChanged("EnglishWord");
            }
        }

        public string Transcription
        {
            get { return _transcription; }
            set
            {
                _transcription = value;
                OnPropertyChanged("Transcription");
            }
        }

        public string ResoursePhoto
        {
            get { return _resoursePhoto; }
            set
            {
                _resoursePhoto = value;
                OnPropertyChanged("ResoursePhoto");
            }
        }

        #endregion

        #region ICommand 

        public ICommand Next
        {
            get
            {
                return new RelayCommand(x => this.NextWord());
            }
        }
              
        public ICommand YourShooseVersionOne
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionOne, _transcription));
            }
        }        

        public ICommand YourShooseVersionTwo
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionTwo, _transcription));
            }
        }

        public ICommand YourShooseVersionThree
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionTwo, _transcription));
            }
        }

        public ICommand YourShooseVersionFour
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionTwo, _transcription));
            }
        }

        public ICommand YourShooseVersionFive
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionTwo, _transcription));
            }
        }

        public ICommand YourShooseVersionSix
        {
            get
            {
                return new RelayCommand(x => this.ShooseWordVersionOne(_englishWord, _versionTwo, _transcription));
            }
        }

        #endregion

        private void ShooseWordVersionOne(string englishWord, string versionOne, string transcription)
        {

        }

        private void NextWord()
        {
            if (_index<6)
            {
                var _currentItem = data.GetDictionary.Values.ElementAt(_index);
                EnglishWord = _currentItem.WordEngl;
                Transcription = _currentItem.WordTranscription;
                VersionOne = data.GetUkrWord();
                VersionTwo = data.GetUkrWord();
                VersionThree = data.GetUkrWord();
                VersionFour = data.GetUkrWord();
                VersionFive = data.GetUkrWord();
                VersionSix = data.GetUkrWord();

                ResoursePhoto = data.GetDictionary.Keys.ElementAt(_index);
                _index++;
               
            }
            else
            {
                _codeBehind.LoadView(ViewType.DesignWords);
            }
        }


        public TestVM(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;

            var _firstItem = data.GetDictionary.Values.First();
            _englishWord = _firstItem.WordEngl;
            _transcription = _firstItem.WordTranscription;
            _versionOne = data.GetUkrWord();
            _versionTwo = data.GetUkrWord();
            _versionThree = data.GetUkrWord();
            _versionFour = data.GetUkrWord();
            _versionFive = data.GetUkrWord();
            _versionSix = data.GetUkrWord();

            _resoursePhoto = data.GetDictionary.Keys.First();

        }
    }
}
