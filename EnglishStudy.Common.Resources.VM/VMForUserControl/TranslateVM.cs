
using EnglishStudy.BL.Implement.Implement;
using EnglishStudy.Common.Resources.VM.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishLearn.Common.Resources.VM.VMForUserControl
{
   public class TranslateVM : ViewModelBase
    {
        private ObservableCollection<string> salesPeriods = new ObservableCollection<string>();

        public ObservableCollection<string> SalesPeriods
        {
            get { return salesPeriods; }
            set { salesPeriods = value;
               OnPropertyChanged("SalesPeriods"); }
        }
        private string selectedItem;
        private string _textForTranslate;

        public string TextForTranslate
        {
            get { return _textForTranslate; }
            set
            {
                _textForTranslate = value;
                OnPropertyChanged("TextForTranslate");
            }
        }

        public string SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                  OnPropertyChanged("SelectedItem"); }
        }

        public string SelectedItemTwo
        {
            get { return _selectedItemTwo; }
            set
            {
                _selectedItemTwo = value;
                OnPropertyChanged("SelectedItemTwo");
            }
        }

        
        // bt.Translator(tr.Text, bt.GetLangPair(TranlateWith.SelectedItem.ToString(),TranlateOn.SelectedItem.ToString()) 

        public ICommand TranslateCommand
        {
            get
            {
                return new RelayCommand(x => this.Translate());
            }
        }

        private void Translate()
        {           
            string a = bt.Translator(_textForTranslate, bt.GetLangPair(selectedItem,selectedItem));
            MessageBox.Show(a);
        }

        BTransletor bt;
        private string _selectedItemTwo;

        public TranslateVM()
        {
            bt = new BTransletor();
            SalesPeriods.Add("Український");
            SalesPeriods.Add("Англійський");
            SelectedItem = "Український";
            SelectedItemTwo = "Англійський";
        }
    }
}
