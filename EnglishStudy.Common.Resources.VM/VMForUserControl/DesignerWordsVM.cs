
using EnglishStudy.BL.Implement.Implement;
using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;
using System;
using System.Linq;
using EnglishStudy.Entity.Abstract.Enum;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
    public class DesignerWordsVM : ViewModelBase
    {
        private IMainWindowsCodeBehind _codeBehind;

        private Data _data = new Data();

        private int _count = 0;

        private  int _index = 1;        

        ObservableCollection<TextBox> _emptyWordCollection;

        ObservableCollection<TextBox> _englishWordCollection;
        private int _indexEWC = 0;
        private string _englishWord;

        public ObservableCollection<TextBox> EnglishWordCollection
        {
            get
            {
                if (_englishWordCollection == null)
                {
                    _englishWordCollection = new ObservableCollection<TextBox>();

                    var firstItem = _data.GetDictionary.Values.First();

                    _count = firstItem.WordEngl.Count();

                    SomeSetting.AddTB(_englishWordCollection, _count);

                    SomeSetting.SettingTB(_englishWordCollection);

                    SomeSetting.AddTextToTB(firstItem.WordEngl.ToArray(), _englishWordCollection);

                    foreach (var item in _englishWordCollection)
                    {
                        item.MouseDoubleClick += (s, e) =>
                        {
                            _emptyWordCollection[_indexEWC].Text = item.Text;
                            _indexEWC++;
                            _englishWordCollection.Remove(item);
                        };
                    }

                }

                return _englishWordCollection;
            }
            set
            {
                _englishWordCollection = value;
                OnPropertyChanged("EnglishWordCollection");
            }
        }

        public ObservableCollection<TextBox> EmptyWordCollection
        {
            get
            {
                if (_emptyWordCollection == null)
                {
                    _emptyWordCollection = new ObservableCollection<TextBox>();

                    var firstItem = _data.GetDictionary.Values.First();

                    _count = firstItem.WordEngl.Count();

                    SomeSetting.AddTB(_emptyWordCollection,_count);

                    SomeSetting.SettingTB(_emptyWordCollection);

                    foreach (var item in _emptyWordCollection)
                    {
                        item.MouseDoubleClick += (s, e) =>
                        {
                            _englishWordCollection.Add(new TextBox());

                            SomeSetting.SettingTB(_englishWordCollection);

                            _englishWordCollection.Last().Text = item.Text;

                            item.Text = String.Empty;
                        };
                    }
                }

                return _emptyWordCollection;
            }
            set
                {
                    _emptyWordCollection = value;
                    OnPropertyChanged("EmptyWordCollection");
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
            _indexEWC = 0;

            if (_index < Word.CountWordForLearning)
            {                

                _englishWord = _data.GetDictionary.Values.ElementAt(_index).WordEngl;

                string _previousEnglishWord = _data.GetDictionary.Values.ElementAt(_index-1).WordEngl;

                IsCorrectAnswer(_previousEnglishWord);

                char[] _word = _englishWord.ToCharArray();

                _emptyWordCollection = null;

                _englishWordCollection = null;

                if (_englishWordCollection == null)
                {
                    EnglishWordCollection = new ObservableCollection<TextBox>();

                    _count = _word.Count();

                    SomeSetting.AddTB(EnglishWordCollection, _count);

                    SomeSetting.SettingTB(EnglishWordCollection);

                    SomeSetting.AddTextToTB(_word, EnglishWordCollection);

                    foreach (var item in _englishWordCollection)
                    {
                        item.MouseDoubleClick += (s, e) =>
                        {
                            _emptyWordCollection[_indexEWC].Text = item.Text;
                            _indexEWC++;
                            _englishWordCollection.Remove(item);
                        };
                    }


                }

                if (_emptyWordCollection == null)
                {
                    EmptyWordCollection = new ObservableCollection<TextBox>();

                    _count = _word.Count();

                    SomeSetting.AddTB(EmptyWordCollection, _count);

                    SomeSetting.SettingTB(EmptyWordCollection);

                    foreach (var item in _emptyWordCollection)
                    {
                        item.MouseDoubleClick += (s, e) =>
                        {
                            _englishWordCollection.Add(new TextBox());

                            SomeSetting.SettingTB(_englishWordCollection);

                            _englishWordCollection.Last().Text = item.Text;

                            item.Text = String.Empty;
                        };
                    }
                }

               

                _index++;
               
            }
            else
            {
                _codeBehind.LoadView(ViewType.Lisening);
            }
           
        }

        public DesignerWordsVM(IMainWindowsCodeBehind codeBehind)
        {            
            _codeBehind = codeBehind;
            
        }

        private void IsCorrectAnswer(string englWord)
        {
            string _answer = null;

            foreach (var item in _emptyWordCollection)
            {
                _answer += item.Text;
            }

            if (englWord.Equals(_answer))
            {
                Word.MarksArray[_index-1] += 1;
            }
            
        }
    }
}
