﻿using EnglishLearn.Common.Resources.VM.VMForUserControl;
using EnglishStudy.Common.Resources.VM.Abstract;
using EnglishStudy.Common.Resources.VM.VMForUserControl;
using EnglishStudy.Common.UserControl.UserControl;
using EnglishStudy.Entity.Abstract.Enum;
using EnglishStudy.Recourses.Style.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind 
    {
        public MainWindow()
        {
            InitializeComponent();            
            this.Closing += MainWindow_Closing;            
            this.Loaded += MainWindow_Loaded;
        }

        #region EventWindow

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadView(ViewType.ShooseThems);
            UpdateStyle.SetThemes("Dark");//0003B FFD0B 85B84F
        }



        private void MainWindow_Closing(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
            //string warning = MessegeHolder.Message.Message.GetWarningMessag(MessageType.Exit);
            //DialogResult result = System.Windows.Forms.
            //        MessageBox.Show(warning, "", MessageBoxButtons.YesNo);

            //if (result == System.Windows.Forms.DialogResult.Yes)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        #endregion

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.LearnWords:
                    LearnWords view = new LearnWords();
                    VMLearnWords vmLearnWords = new VMLearnWords(this);
                    LoadUserControl(view, vmLearnWords);
                    break;
                case ViewType.TestWords:
                    Test test = new Test();
                    TestVM vmTest = new TestVM(this);
                    LoadUserControl(test, vmTest);
                    break;
                case ViewType.DesignWords:
                    DesignerWord designerWord = new DesignerWord();
                    DesignerWordsVM vmdesignerWor = new DesignerWordsVM(this);
                    LoadUserControl(designerWord, vmdesignerWor);
                    break;
                case ViewType.Lisening:
                    Lisening lisening = new Lisening();
                    LiseningVM vmLisening = new LiseningVM(this);
                    LoadUserControl(lisening, vmLisening);
                    break;                    
                 case ViewType.ShooseThems:
                    SettingView settingView = new SettingView();
                    ShooseStyleVM vmShooseStyle = new ShooseStyleVM(this);
                    LoadUserControl(settingView, vmShooseStyle);
                    break;
                case ViewType.ResultLearning:
                    ResultLearning resultLearning = new ResultLearning();
                    ResultLearningVM vmResultLearning = new ResultLearningVM();
                    LoadUserControl(resultLearning, vmResultLearning);
                    break;
                case ViewType.Translate:
                    Translate translate = new Translate();
                    TranslateVM translateVM = new TranslateVM();
                    LoadUserControl(translate, translateVM);
                    break;
                case ViewType.AddWords:
                    AddWordsVM addWordsVM = new AddWordsVM();
                    AddWordsUC addWordsUC = new AddWordsUC(); 
                    LoadUserControl(addWordsUC, addWordsVM);
                    break;



            }
        }

        private void LoadUserControl(UserControl control, ViewModelBase vm)
        {
            control.DataContext = vm;
            this.Content = control;
        }

    }
}
