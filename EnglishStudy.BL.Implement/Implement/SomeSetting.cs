using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EnglishStudy.BL.Implement.Implement
{
    public class SomeSetting
    {
        static Random random = new Random();

        static List<string> _list = new List<string>();

        public static void AddTB(ObservableCollection<TextBox> collection, int length)
        {
            for (int i = 0; i < length; i++)
            {
                collection.Add(new TextBox());
            }
        }

        public static void SettingTB(ObservableCollection<TextBox> collection)
        {
            foreach (var item in collection)
            {
                item.Margin = new Thickness(10);
                item.MinHeight = 50;
                item.MinWidth = 50;
                item.FontSize = 32;
                item.HorizontalContentAlignment = HorizontalAlignment.Center;
                item.VerticalContentAlignment = VerticalAlignment.Center;
            }
        }

        public static void AddTextToTB( char [] mas, ObservableCollection<TextBox> collection)
        {
            string currentWord = String.Empty;

            for (int i = 0; i < collection.Count; i++)
            {
                _list.Add(mas[i].ToString());
                
            }

            for (int i = 0; i < collection.Count; i++)
            {
                currentWord = _list.ElementAt(random.Next(0, _list.Count));
                collection[i].Text = currentWord;
                _list.Remove(currentWord);
            }
        }
    }
}
