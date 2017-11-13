﻿using EnglishStudy.BL.Implement.Implement;
using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.Base;
using System.Linq;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;
using System;
using System.Windows;

namespace EnglishStudy.Common.Resources.VM.VMForUserControl
{
    public class LiseningVM : ViewModelBase
    {
        private string _answer;

        private string _englishWord;
        private IMainWindowsCodeBehind _codeBehind;
        Data _data = new Data();
        private int _index = 1;

        public LiseningVM(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
            _englishWord = _data.GetDictionary.Values.First().WordEngl;
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

        public string Answer
        {
            get { return _answer; }
            set
            {
                _answer = value;
                OnPropertyChanged("Answer");
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
            if (_index<6)
            {
                EnglishWord = _data.GetDictionary.Values.ElementAt(_index).WordEngl;
                _index++;
            }
        }
    }
}

