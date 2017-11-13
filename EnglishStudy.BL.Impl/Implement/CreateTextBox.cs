using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EnglishLearn
{
    class CreateTextBox
    {
        public static void CreateTextBoxs(StackPanel EnglishWord, StackPanel EmptyWord,  char[] arrayLetter)
        {
            int size = arrayLetter.Length;
            TextBox[] txtTeamNames = new TextBox[size];
            TextBox txt = null;
            TextBox txt1 = null;

            for (int i = 0; i < txtTeamNames.Length; i++)
            {                
                txt = new TextBox();
                txt1 = new TextBox();

                txtTeamNames[i] = txt;               
                txt.Text = arrayLetter[i].ToString();
               // EnglishWord.Children.Add(txt);
               // EmptyWord.Children.Add(txt1);


            }

            txt.MouseEnter += (s, e) => 
                                        {
                                          txt1.Text = txt.Text; EnglishWord.Children.Remove(txt);
                                        };
        }
    }
}
