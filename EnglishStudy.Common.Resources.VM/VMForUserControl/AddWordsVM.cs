using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.Base;
using EnglishStudy.DB.Abstract.Implement;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
   public class AddWordsVM : ViewModelBase
    {
        #region 
                private string _ukrWord;

                private string _englWord;

                private string _tranckWord;      

                private string _sourseImage;
               
        #endregion
        private IMainWindowsCodeBehind _codeBehind;

#region
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

        public string TranckriptionWord
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

        public DataTable Table { get; set; }

#endregion

       

        public AddWordsVM()
        {
            Table = EnglishStudyDB.GetTable();
           // AddWords();
        }

        private RelayCommand _addWordsCommand;

        public ICommand AddWordsMethot
        {
            get
            {
                _addWordsCommand = new RelayCommand
                    (AddWordsCommand, IsEmpty);

                return _addWordsCommand;
            }
        }

        private RelayCommand _selectImage;

        public ICommand SelectImageMethod
        {
            get
            {
                _selectImage = new RelayCommand
                    (SelectImage, (object o) => true);

                return _selectImage;
            }
        }

        private void SelectImage(object obj)
        {
            MessageBox.Show("d");
        }

        private bool IsEmpty(object obj)
        {
            if (_englWord != null && _ukrWord != null && _tranckWord != null)
            {
                return true;
            }

            return false;
        }

        private void AddWordsCommand(object obj)
        {
            MessageBox.Show("d");
        }
    }
}
