using EnglishStudy.BL.Implement.Implement;
using EnglishStudy.DB.Abstract.Implement;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
    public class ResultLearningVM : ViewModelBase
    {
        //private ObservableCollection<string> _ukrWord;

        //private ObservableCollection<string> _englWord;

        private ObservableCollection<Word> _collection;


        //public ObservableCollection<string> UkrWord
        //{
        //    get { return _ukrWord; }
        //    set
        //    {
        //        _ukrWord = value;
        //        OnPropertyChanged("UkrWord");
        //    }
        //}

        //public ObservableCollection<string>  EnglWord
        //{
        //    get { return _englWord; }
        //    set
        //    {
        //        _englWord = value;
        //        OnPropertyChanged("EnglWord");
        //    }
        //}

        public ObservableCollection<Word> Collection
        {
            get { return _collection; }
            set
            {
                _collection = value;
                OnPropertyChanged("Collection");
            }
        }
        
        Data data = new Data();
        private int _index =0;

        public ResultLearningVM()
        {
            _collection = new ObservableCollection<Word>();            

            foreach (var item in data.GetDictionary)
            {
                _collection.Add(new Word(item.Value.WordUkr, item.Value.WordEngl, Word.MarksArray[_index].ToString()+"/3" , item.Key));
                _index++;
            }

            EnglishStudyDB.UpdateStatus();


        }


    }
}
